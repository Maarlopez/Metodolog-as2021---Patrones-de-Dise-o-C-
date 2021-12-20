using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Strategy
{
    class EstrategiaPorCalificacion : EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Calificacion == ((IAlumno)elemento2).Calificacion;
        }

        public bool sosMayor(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Calificacion < ((IAlumno)elemento2).Calificacion;
        }

        public bool sosMenor(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Calificacion > ((IAlumno)elemento2).Calificacion;
        }
    }
}
