using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Decorator
{
    class NotaMarco : AlumnoDecorator
    {
        public NotaMarco(AlumnoAbstracto _alumnoComponent) : base(_alumnoComponent) { }
        public override string MostrarCalificacion()
        {
            string marco = "**************************************";
            marco += "\n *  " + base.MostrarCalificacion() + "*";
            marco += "\n **************************************";
            return marco;
        }
    }
}
