using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Decorator
{
    class NotaIndice : AlumnoDecorator
    {
        static int cont = 1;
        public NotaIndice(AlumnoAbstracto _alumnoComponent) : base(_alumnoComponent) { }
        public override string MostrarCalificacion()
        {
            string calificacion = base.MostrarCalificacion();
            string imprimir = calificacion.Insert( 0, cont + ")");
            cont++;
            return imprimir;
        }
    }
}
