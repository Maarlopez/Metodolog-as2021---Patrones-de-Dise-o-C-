using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Iterator;

namespace TP4
{
	class Test
	{
		public static void Run()
		{
			AlumnoAbstracto alumno = (AlumnoAbstracto)Factory_Method.FabricaDeComparables.CrearComparable("2");

			Console.WriteLine(alumno.MostrarCalificacion());

			//HashSet<int> conjunto = new HashSet<int>();
			//conjunto.Add(1);
			//conjunto.Add(2);
			//conjunto.Add(3);
			//var iterator = conjunto.GetEnumerator();

			//Dictionary<object, Comparable> elementos = new Dictionary<object, Comparable>();

			//while (iterator.MoveNext())
			//{
			//	Console.WriteLine(iterator.Current);
			//}
		}
    }
}
