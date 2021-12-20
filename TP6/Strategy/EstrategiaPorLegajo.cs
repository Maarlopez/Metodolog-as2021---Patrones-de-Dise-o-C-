using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Strategy;

namespace TP6.Strategy
{
    public class EstrategiaPorLegajo : EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(IComparable elemento, IComparable elemento2)
        {
           return ((IAlumno)elemento).Legajo.CompareTo(((IAlumno)elemento2).Legajo)==0;
        }

        public bool sosMayor(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Legajo < ((IAlumno)elemento2).Legajo;
        }

        public bool sosMenor(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Legajo > ((IAlumno)elemento2).Legajo;
        }
    }
}
