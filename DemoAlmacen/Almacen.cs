using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatronProductorConsumidor
{
    public class Almacen<T>
    {
        private int CapacidadMaxima;
        private Queue<T> cola = new Queue<T>();
        private object lockobjeto = new object();

        public Almacen(int capacidad)
        {
            CapacidadMaxima = capacidad;
        }
        public void Agregar(T item)
        {
            lock (lockobjeto)
            {
                while (cola.Count >= CapacidadMaxima)
                {
                    Monitor.Wait(lockobjeto);
                }
                cola.Enqueue(item);
                Monitor.Pulse(lockobjeto);
            }
        }
        public T Extraer()
        {
            lock (lockobjeto)
            {
                while (cola.Count == 0)
                {
                    Monitor.Wait(lockobjeto);
                }
                T item = cola .Dequeue();
                Monitor.Pulse(lockobjeto);
                return item;
            }
        }
    }
}
