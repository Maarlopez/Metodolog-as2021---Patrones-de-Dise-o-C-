using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Strategy;

namespace TP6.Strategy
{
    class EstrategiaPorNombre: EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(IComparable elemento, IComparable elemento2)
        {
            return (((IAlumno)elemento).Nombre).Length == (((IAlumno)elemento2).Nombre).Length;
        }

        public bool sosMayor(IComparable elemento, IComparable elemento2)
        {
            return (((IAlumno)elemento).Nombre).Length < (((IAlumno)elemento2).Nombre).Length;
        }

        public bool sosMenor(IComparable elemento, IComparable elemento2)
        {
            return (((IAlumno)elemento).Nombre).Length > (((IAlumno)elemento2).Nombre).Length;
        }
    }
}
