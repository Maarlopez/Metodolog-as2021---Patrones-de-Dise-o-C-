using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Strategy;

namespace TP3.Strategy
{
    public class EstrategiaPorLegajo : EstrategiaDeAlumnosComparables
    {
        public void llamarComparacion(string ValorP)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
           return ((Alumno)elemento).Legajo.CompareTo(((Alumno)elemento2).Legajo)==0;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Legajo < ((Alumno)elemento2).Legajo;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Legajo > ((Alumno)elemento2).Legajo;
        }
    }
}
