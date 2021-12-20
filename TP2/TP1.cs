using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class TP1
    {
		public static void Run()
		{
			Coleccionable unColeccion = new Pila();
			Llenar(unColeccion);
			Informar(unColeccion);
		}

		public static void Llenar(Coleccionable coleccionable)
		{
			for (int i = 0; i < 20; i++)
			{
				coleccionable.Agregar(new Numero(new Random().Next(0, 100)));
			}
		}

		public static void Informar(Coleccionable coleccionable)
		{
			Console.WriteLine("Cuantos: " + coleccionable.cuantos());
			Console.WriteLine("Minimo: " + coleccionable.Minimo());
			Console.WriteLine("Maximo: " + coleccionable.Maximo());
		}

		public static void llenarAlumnos(Coleccionable coleccionable)
		{
			List<Comparable> comparablesList = new List<Comparable>();
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
