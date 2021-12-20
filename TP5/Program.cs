using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Decorator;
using TP5.Iterator;
using TP5.Strategy;

namespace TP5
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
                Console.WriteLine("6- Adapter");
                Console.WriteLine("7- Decorator");
                Console.WriteLine("8- Proxy");
                Console.WriteLine("9 - Command");
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
                    case "6":
                        PAdapter.Run();
                        break;
                    case "7":
                        PDecorator.Run();
                        break;
                    case "8":
                        PProxy.Run();
                        break;
                    case "9":
                        PCommand.Run();
                        break;
                    case "25":
                            TestConjuntoDiccionario.Run();
                            break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            Console.WriteLine("Toque una tecla para terminar");
            Console.ReadKey();
        }
    }
}
