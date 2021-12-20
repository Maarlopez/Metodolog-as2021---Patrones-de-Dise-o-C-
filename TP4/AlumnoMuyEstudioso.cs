 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4
{
    class AlumnoMuyEstudioso : AlumnoConcreto
    {
        public EstrategiaDeAlumnosComparables EstrategiaDeComparacionActual;
        public override int ResponderPregunta(int pregunta)
        {
            return (pregunta % 3);
        }
    }
}
