using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Adapter
{
    class AlumnoToStudent : Student
    {
        AlumnoAbstracto _alumno;

        public AlumnoToStudent(AlumnoAbstracto alumno)
        {
            this._alumno = alumno;
        }
        public bool equals(Student student)
        {
            return _alumno.sosIgual(((AlumnoToStudent)student)._alumno);
        }

        public string getName()
        {
            return _alumno.Nombre;   
        }

        public bool greaterThan(Student student)
        {
            return _alumno.sosMayor(((AlumnoToStudent)student)._alumno);
        }

        public bool lessThan(Student student)
        {
            return _alumno.sosMenor(((AlumnoToStudent)student)._alumno);
        }

        public void setScore(int score)
        {
            _alumno.Calificacion = score;
        }

        public string showResult()
        {
            return _alumno.MostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
           return _alumno.ResponderPregunta(question);
        }
    }
}
