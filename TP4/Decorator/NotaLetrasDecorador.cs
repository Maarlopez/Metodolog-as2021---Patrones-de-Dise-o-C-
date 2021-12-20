using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Decorator
{
    class NotaLetrasDecorator : AlumnoDecorator
    {
        Dictionary<int, string> dicctionary = new Dictionary<int, string>();
        public NotaLetrasDecorator(AlumnoAbstracto alumnoComponent) : base(alumnoComponent)
        {
            dicctionary.Add(0, "Cero");
            dicctionary.Add(1, "Uno");
            dicctionary.Add(2, "Dos");
            dicctionary.Add(3, "Tres");
            dicctionary.Add(4, "Cuatro");
            dicctionary.Add(5, "Cinco");
            dicctionary.Add(6, "Seis");
            dicctionary.Add(7, "Siete");
            dicctionary.Add(8, "Ocho");
            dicctionary.Add(9, "Nueve");
            dicctionary.Add(10, "Diez");
        }
        public override string MostrarCalificacion()
        {
            return this._alumnoComponent.MostrarCalificacion()
                + "(" + dicctionary[_alumnoComponent.Calificacion] + ")";

        }
    }
}
