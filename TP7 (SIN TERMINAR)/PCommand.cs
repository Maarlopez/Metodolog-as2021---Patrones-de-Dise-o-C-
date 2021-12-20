using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class PCommand
    {
        public static void Run()
        {
            Pila p = new Pila();
            Aula a = new Aula();
            p.setOrdenInicio(new OrdenInicio(a));
            p.setOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
            p.setOrdenAulaLlena(new OrdenAulaLlena(a));
            Helper.Llenar(p, "2");
            //Helper.Llenar(p, "4");

            //Console.WriteLine("Pulse una tecla para continuar...");
            //Console.ReadKey();
        }
    }
}