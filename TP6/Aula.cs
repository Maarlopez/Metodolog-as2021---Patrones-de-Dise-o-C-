using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Adapter;

namespace TP6
{
    class Aula
    {
        Teacher teacher;

        public void Comenzar()
        {
            teacher = new Teacher();
            Console.WriteLine("Comienzo de la clase...");
        }

        public void nuevoAlumno(IComparable alumno)
        {
            Student student = new AdaptadorAlumno((IAlumno)alumno);
            teacher.goToClass(student);
            Console.WriteLine("Llego el alumno: " + student.getName());
        }

        public void ClaseLista()
        {
            Console.WriteLine("El aula esta llena...");
            teacher.teachingAClass();
        }
    }
}
