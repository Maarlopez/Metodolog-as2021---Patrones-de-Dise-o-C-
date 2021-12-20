using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    public class LectorDeDatos: Manejador
    {
        private static LectorDeDatos instance = null;
        public LectorDeDatos(Manejador siguiente) : base(siguiente) { }
        public static LectorDeDatos GetInstance(Manejador siguiente)
        {
            if (instance == null)
                instance = new LectorDeDatos(siguiente);
            return instance;
        }
        //devuelve un número leído por teclado
        public override int numeroPorTeclado() 
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        //devuelve un string leído por teclado
        public override string stringPorTeclado() 
        {
            string str;
            Console.WriteLine("Ingrese un string: ");
            str = Console.ReadLine();
            return str;
        }
    }
}
