using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
    public class Consumidor
    {
        private Almacen<Usuario> _almacen;
        public Consumidor(Almacen<Usuario> almacen)
        {
            _almacen = almacen;
        }
        public Usuario Consumir()
        {
            Usuario usuario = _almacen.Extraer();
            Thread.Sleep(5000);
            return usuario;
        }

    }
}
