using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Iterator;

namespace TP7
{
    class TestConjuntoDiccionario
    {
        public static void Run()
        {
            Console.WriteLine("Alumnos agregados a diccionario");
            Diccionario dic = new Diccionario();
            dic.Agregar(new ClaveValor(new Numero(111), new Alumno { Dni = 111, Nombre = "Jose" }));
            dic.Agregar(new ClaveValor(new Numero(222), new Alumno { Dni = 222, Nombre = "Maria" }));
            dic.Agregar(new ClaveValor(new Numero(333), new Alumno { Dni = 333, Nombre = "Alfredo" }));

            Iterador iterdic = dic.crearIterador();
            while (!iterdic.fin())
            {
                Console.WriteLine("Alumno en diccionario {0}, Dni {1},",((Alumno)iterdic.actual()).Nombre, ((Alumno)iterdic.actual()).Dni);
                iterdic.siguiente();
            }
            IComparable alumno = dic.ValorDe(new Numero(111));
            Console.WriteLine("el alumno con clave Numero(111) es {0}",alumno);
            Console.WriteLine();

        }
    }
}
