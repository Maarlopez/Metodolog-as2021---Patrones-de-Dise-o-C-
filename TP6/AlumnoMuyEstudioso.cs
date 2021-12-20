 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Strategy;

namespace TP6
{
    class AlumnoMuyEstudioso : Alumno
    {
        public EstrategiaDeAlumnosComparables EstrategiaDeComparacionActual;
        public override int ResponderPregunta(int pregunta)
        {
            return (pregunta % 3);
        }
    }
}
