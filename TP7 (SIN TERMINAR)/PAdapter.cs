using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Adapter;
using TP7.Decorator;
using TP7.Factory_Method;
using TP7.Iterator;

namespace TP7
{
    public class PAdapter
    {
        public static void Run()
        {
            Teacher teacher = Teacher.GetInstance();
            Pila pila = new Pila();
            Helper.Llenar(pila, "2");
            Iterador iter = pila.crearIterador();
            int i = 0;
            while (!iter.fin() && i<10)
            {
                IAlumno alumno = (IAlumno)iter.actual();
                Student student = new AdaptadorAlumno(alumno);
                teacher.goToClass(student);
                iter.siguiente();
            }
            //i = 0;
            Pila pila2 = new Pila();
            Helper.Llenar(pila2, "4");
            teacher.teachingAClass();
            //iter = pila.crearIterador();
            //while (!iter.fin() && i < 10)
            //{
            //    AlumnoConcreto alumno = (AlumnoConcreto)iter.actual();
            //    AlumnoToStudent student = new AlumnoToStudent(alumno);
            //    teacher.goToClass((Student)student);
            //    iter.siguiente();
            //}



            //ListOfStudent listOfStudent = new ListOfStudent();
            //listOfStudent.addStudent(new AlumnoToStudent(new Alumno()));

            //for(int i=0; i<10; i++)
            //{
            //    Alumno alumno = (Alumno)FabricaDeComparables.CrearComparable("2");
            //    AlumnoToStudent student = new AlumnoToStudent(alumno);
            //    teacher.goToClass(student);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso)FabricaDeComparables.CrearComparable("2");
            //    AlumnoToStudent student = new AlumnoToStudent(alumno);
            //    teacher.goToClass(student);
            //}


        }
    }
}
