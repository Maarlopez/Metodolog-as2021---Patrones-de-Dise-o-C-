using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Observer;
using TP3.Factory_Method;

namespace TP3
{
    public class Gerente: IObserver
    {
        Pila mejores = new Pila();
        public void Cerrar() 
        {
            Console.WriteLine("Los mejores son: /n" + DateTime.Now.ToShortDateString());
            var iterador = mejores.crearIterador();
            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual());
                iterador.siguiente();
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
