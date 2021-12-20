using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4.Strategy
{
    class EstrategiaPorPromedio: EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Promedio == ((AlumnoAbstracto)elemento2).Promedio;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Promedio < ((AlumnoAbstracto)elemento2).Promedio;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Promedio > ((AlumnoAbstracto)elemento2).Promedio;
        }
    }
}
