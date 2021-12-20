using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Factory_Method;
using TP3.Iterator;

namespace TP3
{
    class Helper
    {
        public static void Informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad de  elementos en el coleccionable: " + coleccionable.cuantos());
            Console.WriteLine("El elemento mas chico en el coleccionable: " + coleccionable.Minimo());
            Console.WriteLine("El elemento mas grande en el coleccionable: " + coleccionable.Maximo());
        }

        public static void ImprimirElementos(Coleccionable coleccionable)
        {
            var iter = coleccionable.crearIterador();
            while (!iter.fin())
            {
                Console.WriteLine(iter.actual());
                iter.siguiente();
            }
        }

        public static Coleccionable Llenar(Coleccionable coleccionable, string option)
        {
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(FabricaDeComparables.CrearComparable(option));
            }
            return coleccionable;
        }

        public static string nombreRamdom()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Pedro");
            nombres.Add("Jose");
            nombres.Add("María");
            nombres.Add("Juana");
            nombres.Add("Alfredo");
            nombres.Add("Mariana");
            nombres.Add("Veronica");
            nombres.Add("Mirta");
            nombres.Add("Javier");
            nombres.Add("Ludmila");
            nombres.Add("Tamara");
            nombres.Add("Aylen");
            nombres.Add("Florencia");
            nombres.Add("Ruben");
            //int posicion = new Random().Next(nombres.Count - 1);
            //string nombreRandom = nombres[posicion];
            return nombres[new Random().Next(nombres.Count)];
        }
    }
}
