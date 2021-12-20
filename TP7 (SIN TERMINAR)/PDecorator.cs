using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Decorator;
using TP7.Strategy;

namespace TP7
{
    class PDecorator
    {

        internal class StudentComparer : IComparer<IAlumno>
        {
            public int Compare(IAlumno s1, IAlumno s2)
            {
                if (s1.sosIgual(s2))
                    return 0;
                else
                if (s1.sosMenor(s2))
                    return 1;
                else
                    return -1;
            }
        }

        public static void Run()
        {
            List<IAlumno> list = new List<IAlumno>();

            // este codigo va adentro de una fabrica
            for (int i = 0; i < 10; i++)
            {
                IAlumno alumno = new Alumno
                {
                    Nombre = Helper.nombreRandom(),
                    Dni = new Random().Next(1000),
                    Legajo = new Random().Next(1000),
                    Calificacion = new Random().Next(10),
                    //EstrategiaDeAlumnosComparables = new EstrategiaPorCalificacion()
                };
                alumno = new LegajoDecorator(alumno);
                alumno = new NotaLetrasDecorator(alumno);
                alumno = new NotaAprobacion(alumno);
                alumno = new NotaIndice(alumno);
                alumno = new NotaMarco(alumno);
                alumno.SetEstrategia(new EstrategiaPorCalificacion());
                list.Add(alumno);
            }

            list.Sort(new StudentComparer());
            foreach (IAlumno alumno in list)
            {
                Console.WriteLine(alumno.MostrarCalificacion());
            }
        }

    }
}