using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Strategy
{
    class EstrategiaPorCalificacion : EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Calificacion == ((AlumnoAbstracto)elemento2).Calificacion;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Calificacion < ((AlumnoAbstracto)elemento2).Calificacion;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Calificacion > ((AlumnoAbstracto)elemento2).Calificacion;
        }
    }
}
