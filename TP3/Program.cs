using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Iterator;
using TP3.Strategy;

namespace TP3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una opción: ");
            Console.WriteLine("1- Strategy");
            Console.WriteLine("2- Iterator");
            Console.WriteLine("3- Test");
            Console.WriteLine("4- Factory Method");
            Console.WriteLine("5- Observer");
            Console.WriteLine("25- TestConjunto con iterdor Catedra");

            string option = Console.ReadLine();
            Console.Clear();
            switch (option)
            {
                case "1":
                    PStrategy.Run();
                    break;
                case "2":
                    PIterator.Run();
                    break;
                case "3":
                    Test.Run();
                    break;
                case "4":
                    PFactoryMethod.Run();
                    break;
                case "5":
                    PObserver.Run();
                    break;
                case "25":
                    TestConjuntoDiccionario.Run();
                    break;
            }

            Console.WriteLine("Toque una tecla para terminar");
            Console.ReadKey();

        }
        //public static void Llenar(Coleccionable coleccionable)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        coleccionable.Agregar(new Numero(rnd.Next(1000)));
        //    }
        //}

        //public static void Llenar(Coleccionable coleccionable, EstrategiaDeAlumnosComparables estrategiaDeComparacion)
        //{
        //    Random rnd = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        coleccionable.Agregar(new Numero(rnd.Next(1000)));
        //    }
        //}
        //public static void Informar(Coleccionable coleccionable)
        //{
        //    Console.WriteLine("Cantidad de  elementos en el coleccionable: " + coleccionable.cuantos());
        //    Console.WriteLine("El elemento mas chico en el coleccionable: " + coleccionable.Minimo());
        //    Console.WriteLine("El elemento mas grande en el coleccionable: " + coleccionable.Maximo());

        //    Console.WriteLine("Ingrese un valor: ");
        //    int valor = int.Parse(Console.ReadLine());
        //    Numero numero = new Numero(valor);

        //    if (coleccionable.Contiene(numero))
        //        Console.WriteLine("El valor leído por teclado está en la colección");
        //    else
        //        Console.WriteLine("El valor leído por teclado no está en la colección");
        //}

        //public static void InformarAlumno(Coleccionable coleccionable)
        //{
        //    Console.WriteLine("Cuantos:" + coleccionable.cuantos().ToString());
        //    Console.WriteLine("Minimo:" + coleccionable.Minimo().ToString());
        //    Console.WriteLine("Maximo:" + coleccionable.Maximo().ToString());

        //    Console.WriteLine("Ingrese un legajo: ");
        //    int legajo = int.Parse(Console.ReadLine());
        //    Comparable comp = new Alumno("", int.Parse(Console.ReadLine()), 0, 0);
        //    if (coleccionable.Contiene(comp))
        //    {
        //        Console.WriteLine("La persona esta en la coleccion");
        //    }
        //    else
        //        Console.WriteLine("La persona no esta en la coleccion");

        //}

        //public static void llenarPersonas(Coleccionable coleccionable)
        //{
        //    string[] names = { "Agustin", "Facundo", "Juan", "Margarita", "Ana", "Aylen", "Angela", "Pedro", "Luis", "Patricia", "Paula", "Carlos" };
        //    Random numeroUnico = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        string nombre = names[numeroUnico.Next(names.Length - 1)];
        //        int dni = numeroUnico.Next(11111111, 50999999);
        //        coleccionable.Agregar(new Persona(nombre, dni));
        //    }
        //}

        //public static void imprimirElementos(Iterable elementos)
        //{
        //    Iterador iterador = elementos.crearIterador();
        //    while (!iterador.fin())
        //    {
        //        Console.WriteLine(iterador.actual() + "");
        //        iterador.siguiente();
        //    }
        //}
    }
}
