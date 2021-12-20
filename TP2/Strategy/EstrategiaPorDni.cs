using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Strategy
{
    public class EstrategiaPorDni: EstrategiaDeAlumnosComparables
    {
        public void llamarComparacion(string ValorP)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Dni == ((Alumno)elemento2).Dni;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Dni < ((Alumno)elemento2).Dni;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((Alumno)elemento).Dni > ((Alumno)elemento2).Dni;
        }
    }
}
