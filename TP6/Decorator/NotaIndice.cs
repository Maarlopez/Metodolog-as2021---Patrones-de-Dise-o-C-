using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Decorator
{
    class NotaIndice : Decorator
    {
        static int cont = 1;
        public NotaIndice(IAlumno _alumnoComponent) : base(_alumnoComponent) { }
        public override string MostrarCalificacion()
        {
            string calificacion = base.MostrarCalificacion();
            string imprimir = calificacion.Insert( 0, cont + ")");
            cont++;
            return imprimir;
        }
    }
}
