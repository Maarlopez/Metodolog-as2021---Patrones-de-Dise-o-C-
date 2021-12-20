using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Factory_Method;
using TP4.Iterator;

namespace TP4
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

        public static string nombreRandom()
        {
            List<string> nombres = new List<string>();

            nombres.Add("Federico");
            nombres.Add("Juan");
            nombres.Add("Martin");
            nombres.Add("Victor");
            nombres.Add("Ignacio");
            nombres.Add("Gabriel");
            nombres.Add("Marcelo");
            nombres.Add("Joaquin");
            nombres.Add("Mario");
            nombres.Add("Mario");
            nombres.Add("Santiago");
            nombres.Add("Andres");

            nombres.Add("Maria");
            nombres.Add("Silvina");
            nombres.Add("Josefina");
            nombres.Add("Dolores");
            nombres.Add("Eugenia");
            nombres.Add("Sofia");
            nombres.Add("Adriana");
            nombres.Add("Cristina");
            nombres.Add("Julia");
            nombres.Add("Andrea");
            nombres.Add("Andrea");
            nombres.Add("Mercedez");

            return nombres[new Random().Next(nombres.Count)];
        }
    }
}
