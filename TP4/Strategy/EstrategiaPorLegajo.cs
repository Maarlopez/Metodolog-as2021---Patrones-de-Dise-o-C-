using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4.Strategy
{
    public class EstrategiaPorLegajo : EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
           return ((AlumnoAbstracto)elemento).Legajo.CompareTo(((AlumnoAbstracto)elemento2).Legajo)==0;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Legajo < ((AlumnoAbstracto)elemento2).Legajo;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Legajo > ((AlumnoAbstracto)elemento2).Legajo;
        }
    }
}
