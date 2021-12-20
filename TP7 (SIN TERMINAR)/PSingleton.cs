using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Adapter;
using TP7.Iterator;

namespace TP7
{
    class PSingleton
    {
        public static void Run()
        {
            Teacher teacher = Teacher.GetInstance();

            Pila pila = new Pila();
            Helper.Llenar(pila, "2");
            Iterador iter = pila.crearIterador();
            int i = 0;
            while (!iter.fin() && i < 10)
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
        }
           
    }
}
