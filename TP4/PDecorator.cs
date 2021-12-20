using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Adapter;
using TP4.Decorator;
using TP4.Strategy;

namespace TP4
{
    class PDecorator
    {

        internal class StudentComparer : IComparer<AlumnoAbstracto>
        {
            public int Compare(AlumnoAbstracto s1, AlumnoAbstracto s2)
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
            //List<AlumnoAbstracto> list = new List<AlumnoAbstracto>();

            // este codigo va adentro de una fabrica
            Teacher teacher = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                AlumnoAbstracto alumno = new AlumnoConcreto
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
                teacher.goToClass(new AlumnoToStudent(alumno));
                
                //list.Add(alumno);
            }
            teacher.teachingAClass();

            //list.Sort(new StudentComparer());
            //foreach (AlumnoAbstracto alumno in list)
            //{
            //    Console.WriteLine(alumno.MostrarCalificacion());
            //}
        }

    }
}