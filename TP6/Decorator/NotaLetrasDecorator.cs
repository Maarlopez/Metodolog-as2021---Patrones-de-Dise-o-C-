using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Decorator
{
    class NotaLetrasDecorator : Decorator
    {
        Dictionary<int, string> dicctionary2 = new Dictionary<int, string>();
        public NotaLetrasDecorator(IAlumno alumnoComponent) : base(alumnoComponent)
        {
            dicctionary2.Add(0, "Cero");
            dicctionary2.Add(1, "Uno");
            dicctionary2.Add(2, "Dos");
            dicctionary2.Add(3, "Tres");
            dicctionary2.Add(4, "Cuatro");
            dicctionary2.Add(5, "Cinco");
            dicctionary2.Add(6, "Seis");
            dicctionary2.Add(7, "Siete");
            dicctionary2.Add(8, "Ocho");
            dicctionary2.Add(9, "Nueve");
            dicctionary2.Add(10, "Diez");
        }
        public override string MostrarCalificacion()
        {
            return this._alumnoComponent.MostrarCalificacion()
                + "(" + dicctionary2[_alumnoComponent.Calificacion] + ")";

        }
    }
}
