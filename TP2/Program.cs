using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;
using TP2.Strategy;

namespace TP2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una opción: ");
            Console.WriteLine("1- Strategy");
            Console.WriteLine("2- Iterator");
            Console.WriteLine("3- Test");
            Console.WriteLine("25- TestConjunto con iterdor Catedra");

            string option = Console.ReadLine();
            Console.Clear();
            switch (option)
            {
                case "1":
                    TP1.Run();
                    break;
                case "2":
                    TP2.Run();
                    break;
                case "3":
                    Test.Run();
                    break;
                case "25":
                    TestConjuntoDiccionario.Run();
                    break;
            }

            Console.WriteLine("Toque una tecla para terminar");
            Console.ReadKey();
        }
    }
}
