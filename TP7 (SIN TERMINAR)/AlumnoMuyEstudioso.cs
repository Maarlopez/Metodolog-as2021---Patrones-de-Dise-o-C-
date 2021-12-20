 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Strategy;

namespace TP7
{
    class AlumnoMuyEstudioso : Alumno
    {
        public EstrategiaDeAlumnosComparables EstrategiaDeComparacionActual;

        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio) : base(nombre, dni, legajo, promedio)
        {
        }

        public override int ResponderPregunta(int pregunta)
        {
            return (pregunta % 3);
        }
    }
}
