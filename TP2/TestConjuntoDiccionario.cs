using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;

namespace TP2
{
    class TestConjuntoDiccionario
    {
        public static void Run()
        {


            // diccionario
            Console.WriteLine("Alumnos agregados a diccionario");
            Diccionario dic = new Diccionario();
            dic.Agregar(new ClaveValor(new Numero(111), new Alumno { Dni = 111, Nombre = "Jose", Legajo= 1111 })); //agregue legajo
            dic.Agregar(new ClaveValor(new Numero(222), new Alumno { Dni = 222, Nombre = "Maria", Legajo = 2222 }));
            dic.Agregar(new ClaveValor(new Numero(333), new Alumno { Dni = 333, Nombre = "Alfredo", Legajo = 3333 }));

            Iterador iterdic = dic.crearIterador();
            while (!iterdic.fin())
            {
                Console.WriteLine("Alumno en diccionario {0}, Dni {1},",((Alumno)iterdic.actual()).Nombre, ((Alumno)iterdic.actual()).Dni);
                iterdic.siguiente();
            }
            Comparable alumno = dic.ValorDe(new Numero(111));
            Comparable alumno2 = dic.ValorDe(new Numero(222));
            Comparable alumno3 = dic.ValorDe(new Numero(333));
            Console.WriteLine("el alumno con clave Numero(111) es {0}",alumno);
            Console.WriteLine("el alumno con clave Numero(222) es {0}", alumno2);
            Console.WriteLine("el alumno con clave Numero(333) es {0}", alumno3);
            Console.WriteLine();

        }
    }
}
