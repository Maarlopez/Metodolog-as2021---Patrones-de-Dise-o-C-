using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Decorator
{
    class LegajoDecorator : AlumnoDecorator
    {
        public LegajoDecorator(AlumnoAbstracto alumnoComponent) : base(alumnoComponent) { }

        public override string MostrarCalificacion()
        {
            //return this._alumnoComponet.MostrarCalificación() + "  (" + _alumnoComponet.Legajo+")";
            return this._alumnoComponent.Nombre + "  (" + _alumnoComponent.Legajo + ") " + _alumnoComponent.Calificacion;
        }
    }
}
