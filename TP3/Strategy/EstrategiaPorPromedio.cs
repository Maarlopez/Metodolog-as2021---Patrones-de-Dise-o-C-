using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Strategy;

namespace TP3.Strategy
{
    class EstrategiaPorPromedio: EstrategiaDeAlumnosComparables
    {
        public void llamarComparacion(string ValorP)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Promedio == ((Alumno)elemento2).Promedio;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Promedio < ((Alumno)elemento2).Promedio;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Promedio > ((Alumno)elemento2).Promedio;
        }
    }
}
