using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class PTemplateMethod
    {
		public static void Run()
		{
			Persona p = new Persona("Sofía", 123);
			Persona p1 = new Persona("Alex", 454);
			Persona p3 = new Persona("Maria", 45453);
			Persona p4 = new Persona("Gaston", 45544);

			JuegoDeCartas juego1 = new SumandoCartas();
			Console.WriteLine("El ganador es: " + juego1.jugar(p, p1));

			Console.WriteLine("");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("");

			JuegoDeCartas juego2 = new ContandoCartasPares();
			Console.WriteLine("El ganador es: " + juego2.jugar(p3, p4));


			//Console.WriteLine("Pulse una tecla para continuar...");
			//Console.ReadKey();
		}
    }
}
