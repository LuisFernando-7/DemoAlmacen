using DemoPatronProductorConsumidor;

namespace DemoAlmacen
{
    public partial class Form1 : Form
    {
        private int RegistrarId = 1;
        private Almacen<Usuario> almacenUsuario;
        private Proveedor proveedor;
        private Consumidor consumidor;

        public Form1()
        {
            InitializeComponent();
            almacenUsuario = new Almacen<Usuario>(10);
            proveedor = new Proveedor(almacenUsuario);
            consumidor = new Consumidor(almacenUsuario);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            (
               RegistrarId++,
               txtNombreProductos.Text,
               txtVariedades.Text
            );
            ThreadPool.QueueUserWorkItem
            (
                state =>
                {
                    almacenUsuario.Agregar(nuevoUsuario);

                }
            );
            txtNombreProductos.Clear();
            txtVariedades.Clear();

        }
        private void AgregarUsuarioADataGrid(Usuario usuarios)
        {
            if (dgvVariedades.InvokeRequired)
            {
                dgvVariedades.Invoke(new Action(() =>
                {
                    dgvVariedades.Rows.Add
                         (
                             usuarios.Id, usuarios.NombreProducto,
                             usuarios.VariedadProductos,
                             usuarios.FechaEntrega
                         );
                }));
            }
            else
            {
                dgvVariedades.Rows.Add
                 (
                    usuarios.Id, usuarios.NombreProducto,
                    usuarios.VariedadProductos,
                    usuarios.FechaEntrega
                 );
            }

        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            {
                Thread HiloConsumidor = new Thread(procesarUsuario);
                HiloConsumidor.Start();
            }
            
        }

        private void procesarUsuario()
        {
            Usuario usuario = almacenUsuario.Extraer();
            AgregarUsuarioADataGrid(usuario);
        }
    }
}
