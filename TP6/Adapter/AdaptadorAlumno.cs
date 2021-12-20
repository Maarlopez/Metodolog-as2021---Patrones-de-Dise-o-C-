using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Proxy;

namespace TP6.Adapter
{
    class AdaptadorAlumno : Student
    {
        IAlumno _alumno;
        private AlumnoComposite alumnoComp;
        private IHelperComposite alumnoComp1;

        public AdaptadorAlumno(IAlumno alumno)
        {
            this._alumno = alumno;
        }

        public AdaptadorAlumno(AlumnoComposite alumnoComp)
        {
            this.alumnoComp = alumnoComp;
        }

        public AdaptadorAlumno(IHelperComposite alumnoComp1)
        {
            this.alumnoComp1 = alumnoComp1;
        }

        public bool equals(Student student)
        {
            return _alumno.sosIgual(((AdaptadorAlumno)student)._alumno);
        }

        public string getName()
        {
            return ((IAlumno)_alumno).Nombre;   
        }

        public bool greaterThan(Student student)
        {
            return ((IAlumno)_alumno).sosMayor(((AdaptadorAlumno)student)._alumno);
        }

        public bool lessThan(Student student)
        {
            return ((IAlumno)_alumno).sosMenor(((AdaptadorAlumno)student)._alumno);
        }

        public void setScore(int score)
        {
            ((IAlumno)_alumno).Calificacion = score;
        }

        public string showResult()
        {
            return ((IAlumno)_alumno).MostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
           return _alumno.ResponderPregunta(question);
        }
    }
}
