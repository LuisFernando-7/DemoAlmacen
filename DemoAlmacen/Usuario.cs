using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string NombreProducto { get; set; }
        public string VariedadProductos { get; set; }
        public DateTime FechaEntrega { get; set; }

        public Usuario(int id, string Nombre, string Variedad)
        {
            Id = id;
            NombreProducto = Nombre;
            VariedadProductos = Variedad;
            FechaEntrega = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Id:{Id}, Variedad: {VariedadProductos}, Fecha: {FechaEntrega}";
        }
    }
}
