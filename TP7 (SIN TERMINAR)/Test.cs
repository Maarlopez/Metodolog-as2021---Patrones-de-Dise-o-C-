﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Iterator;

namespace TP7
{
	class Test
	{
		public static void Run()
		{
			IAlumno alumno = (IAlumno)Factory_Method.FabricaDeComparables.CrearComparable("2");

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
