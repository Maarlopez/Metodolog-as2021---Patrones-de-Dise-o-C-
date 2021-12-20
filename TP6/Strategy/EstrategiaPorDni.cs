using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Strategy;

namespace TP6.Strategy
{
    public class EstrategiaPorDni: EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Dni == ((IAlumno)elemento2).Dni;
        }

        public bool sosMayor(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Dni < ((IAlumno)elemento2).Dni;
        }

        public bool sosMenor(IComparable elemento, IComparable elemento2)
        {
            return ((IAlumno)elemento).Dni > ((IAlumno)elemento2).Dni;
        }
    }
}
