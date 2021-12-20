using System;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {

        static void Main(string[] args)
        {
            Numero num = new Numero(20);
            Numero num2 = new Numero { valor = 5 };

            num2.valor = 12;
            Console.WriteLine(num2.valor);
            Console.WriteLine(num.sosMayor(num2));
            Coleccionable coleccionable = null;
            Console.WriteLine("Ingrese un número: ");
            Console.WriteLine("1 Pila ");
            Console.WriteLine("2 Cola ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    coleccionable = new Pila();
                    break;
                case "2":
                    coleccionable = new Cola();
                    break;
            }

            Pila pilaDeNumeros = new Pila();
            Cola colaNumeros = new Cola();
            Helper.Llenar(pilaDeNumeros);
            Helper.Llenar(colaNumeros);
            Helper.Informar(pilaDeNumeros);
            Helper.Informar(colaNumeros);
            Pila pilaDePersonas = new Pila();
            Cola colaPersonas = new Cola();
            Helper.llenarPersonas(pilaDePersonas);
            Helper.llenarPersonas(colaPersonas);
            Helper.llenarAlumnos(colaPersonas);
            Helper.llenarAlumnos(colaPersonas);
            ColeccionMultiple multiple = new ColeccionMultiple(pilaDePersonas, colaPersonas);
            Helper.Informar(multiple);
        }
    }
}
