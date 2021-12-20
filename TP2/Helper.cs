using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;
using TP2.Strategy;

namespace TP2
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

        public static void Llenar(Coleccionable coleccionable)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(new Numero(rnd.Next(1000)));
            }
        }

        public static void Llenar(Coleccionable coleccionable, EstrategiaDeAlumnosComparables estrategiaDeComparacion)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(new Numero(rnd.Next(1000)));
            }
        }
        public static void InformarAlumno(Coleccionable coleccionable)
        {
            Console.WriteLine("Cuantos:" + coleccionable.cuantos().ToString());
            Console.WriteLine("Minimo:" + coleccionable.Minimo().ToString());
            Console.WriteLine("Maximo:" + coleccionable.Maximo().ToString());

            Console.WriteLine("Ingrese un legajo: ");
            int legajo = int.Parse(Console.ReadLine());
            Comparable comp = new Alumno("", int.Parse(Console.ReadLine()), 0, 0);
            if (coleccionable.Contiene(comp))
            {
                Console.WriteLine("La persona esta en la coleccion");
            }
            else
                Console.WriteLine("La persona no esta en la coleccion");

        }
        public static void llenarPersonas(Coleccionable coleccionable)
        {
            string[] names = { "Agustin", "Facundo", "Juan", "Margarita", "Ana", "Aylen", "Angela", "Pedro", "Luis", "Patricia", "Paula", "Carlos" };
            Random numeroUnico = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombre = names[numeroUnico.Next(names.Length - 1)];
                int dni = numeroUnico.Next(11111111, 50999999);
                coleccionable.Agregar(new Persona(nombre, dni));
            }
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

            return nombres[new Random().Next(nombres.Count)];
        }
    }
}
