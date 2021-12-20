using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Decorator
{
    class LegajoDecorator : Decorator
    {
        public LegajoDecorator(IAlumno alumnoComponent) : base(alumnoComponent) { }

        public override string MostrarCalificacion()
        {
            //return this._alumnoComponet.MostrarCalificación() + "  (" + _alumnoComponet.Legajo+")";
            return this._alumnoComponent.Nombre + "  (" + _alumnoComponent.Legajo + ") " + _alumnoComponent.Calificacion;
        }
    }
}
