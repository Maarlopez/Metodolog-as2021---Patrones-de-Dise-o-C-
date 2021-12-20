using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Helper
    {
        public static void Informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad de  elementos en el coleccionable: " + coleccionable.cuantos());
            Console.WriteLine("El elemento mas chico en el coleccionable: " + coleccionable.Minimo());
            Console.WriteLine("El elemento mas grande en el coleccionable: " + coleccionable.Maximo());
        }
        public static void Llenar(Coleccionable coleccionable)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(new Numero(rnd.Next(1000)));
            }
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
        public static void llenarAlumnos(Coleccionable coleccionable)
        {
            string[] names = { "Agustin", "Facundo", "Juan", "Margarita", "Ana", "Aylen", "Angela", "Pedro", "Luis", "Patricia", "Paula", "Carlos" };
            Random numeroUnico = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombre = names[numeroUnico.Next(12)];
                int dni = numeroUnico.Next(11111111, 50999999);
                int legajo = numeroUnico.Next(00000, 99999);
                int promedio = numeroUnico.Next(1, 10);
                coleccionable.Agregar(new Alumno(nombre, dni, legajo, promedio));
            }
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
