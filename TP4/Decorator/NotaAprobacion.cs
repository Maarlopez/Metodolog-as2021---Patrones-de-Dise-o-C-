using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Decorator
{
    class NotaAprobacion : AlumnoDecorator
    {
        public NotaAprobacion(AlumnoAbstracto _alumnoComponent) : base(_alumnoComponent) { } 
            public override string MostrarCalificacion()
            {
                int calificacion = _alumnoComponent.Calificacion;
                string mostrar = _alumnoComponent.MostrarCalificacion(), aux = null;
                int index = mostrar.LastIndexOf(")");
                
                if (calificacion < 4)              
                    aux = "DESAPROBADO";      
                if (calificacion >= 4 && calificacion < 7)
                    aux = "APROBADO";         
                if (calificacion >= 7) aux = "PROMOCION";

                string imprimir = mostrar.Insert(index + 1, "(" + aux + ")");
                Console.WriteLine(imprimir);
                return imprimir;
            }
    }
}