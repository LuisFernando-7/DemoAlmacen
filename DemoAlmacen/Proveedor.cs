using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
    public class Proveedor
    {
        private Almacen<Usuario> _almacen;
        public Proveedor(Almacen<Usuario> almacen)
        {
            _almacen = almacen;
        }
        public void Producir(Usuario itm)
        {
            _almacen.Agregar(itm);
            Thread.Sleep(2000);
        }
    }
}
