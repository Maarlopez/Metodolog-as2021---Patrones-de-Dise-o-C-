using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Iterator;

namespace TP3
{
    public class PObserver
    {
        public static void Run()
        {
            
            //IObserver
            Coleccionable ColeccionVendedores = new Cola();
            Helper.Llenar(ColeccionVendedores, "3");
            Gerente gerente = new Gerente();

            //me suscribo a todos los vendedores
            Iterador iter = ColeccionVendedores.crearIterador();
            while (!iter.fin())
            {
                ((Vendedor)iter.actual()).Agregar(gerente);
                iter.siguiente();
            }

            JornadaDeVentas(ColeccionVendedores);
            gerente.Cerrar();
        }

        public static void JornadaDeVentas(Coleccionable ColeccionVendedores)
        {
            Iterador iter = ColeccionVendedores.crearIterador();
            while (!iter.fin())
            {
                Vendedor vendedor = (Vendedor)iter.actual();
                for (int i = 0; i < 20; i++)
                {
                    vendedor.Venta(new Random().Next(1,7000));
                }
                iter.siguiente();
            }
        }
    }
}
