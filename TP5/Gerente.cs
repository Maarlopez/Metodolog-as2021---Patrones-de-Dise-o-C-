using System;
using TP5.Observer;
using TP5.Iterator;

namespace TP5
{
    public class Gerente : IObserver
    {
        Cola mejores = new Cola();
        public void Cerrar()
        {
            Console.WriteLine("Los mejores son: \n");
            Iterador iter = mejores.crearIterador();
            while (!iter.fin())
            {
                object obj = iter.actual();
                Console.WriteLine((Vendedor)obj);
                iter.siguiente();
            }
        }
        public void Update(object o)
        {
            Venta(((Vendedor)o).ultimaVenta, (Vendedor)o);
        }

        public void Venta(int monto, Vendedor vendedor)
        {
            if (monto > 5000)
            {
                if (mejores.Contiene(vendedor))
                    vendedor.AumentaBonus();
                else
                    mejores.Agregar(vendedor);
            }
        }
    }
}
