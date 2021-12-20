using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class LectorDeDatos
    {
        //devuelve un número leído por teclado
        public int numeroPorTeclado() 
        {
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        //devuelve un string leído por teclado
        public string stringPorTeclado() 
        {
            string str;
            Console.WriteLine("Ingrese un string: ");
            str = Console.ReadLine();
            return str;
        } 
    }
}
