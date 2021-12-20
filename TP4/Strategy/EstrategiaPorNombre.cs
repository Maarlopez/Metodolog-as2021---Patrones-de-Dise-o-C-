using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4.Strategy
{
    class EstrategiaPorNombre: EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
            return (((AlumnoAbstracto)elemento).Nombre).Length == (((AlumnoAbstracto)elemento2).Nombre).Length;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return (((AlumnoAbstracto)elemento).Nombre).Length < (((AlumnoAbstracto)elemento2).Nombre).Length;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return (((AlumnoAbstracto)elemento).Nombre).Length > (((AlumnoAbstracto)elemento2).Nombre).Length;
        }
    }
}
