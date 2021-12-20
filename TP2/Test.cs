using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;

namespace TP2
{
	class Test
	{
		public static void Run()
		{
			HashSet<int> conjunto = new HashSet<int>();
			conjunto.Add(1);
			conjunto.Add(2);
			conjunto.Add(3);
			var iterator = conjunto.GetEnumerator();

			Dictionary<object, Comparable> elementos = new Dictionary<object, Comparable>();

			while (iterator.MoveNext())
			{
				Console.WriteLine(iterator.Current);
			}
		}
    }		
}
