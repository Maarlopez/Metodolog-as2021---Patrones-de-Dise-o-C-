using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Iterator;

namespace TP4
{
    class TestConjuntoDiccionario
    {
        public static void Run()
        {
            Console.WriteLine("Alumnos agregados a diccionario");
            Diccionario dic = new Diccionario();
            dic.Agregar(new ClaveValor(new Numero(111), new AlumnoConcreto { Dni = 111, Nombre = "Jose" }));
            dic.Agregar(new ClaveValor(new Numero(222), new AlumnoConcreto { Dni = 222, Nombre = "Maria" }));
            dic.Agregar(new ClaveValor(new Numero(333), new AlumnoConcreto { Dni = 333, Nombre = "Alfredo" }));

            Iterador iterdic = dic.crearIterador();
            while (!iterdic.fin())
            {
                Console.WriteLine("Alumno en diccionario {0}, Dni {1},",((AlumnoConcreto)iterdic.actual()).Nombre, ((AlumnoConcreto)iterdic.actual()).Dni);
                iterdic.siguiente();
            }
            Comparable alumno = dic.ValorDe(new Numero(111));
            Console.WriteLine("el alumno con clave Numero(111) es {0}",alumno);
            Console.WriteLine();

        }
    }
}
