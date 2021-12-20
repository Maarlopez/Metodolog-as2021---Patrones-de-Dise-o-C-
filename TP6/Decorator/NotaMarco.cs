using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Decorator
{
    class NotaMarco : Decorator
    {
        public NotaMarco(IAlumno _alumnoComponent) : base(_alumnoComponent) { }
        public override string MostrarCalificacion()
        {
            string marco = "**************************************";
            marco += "\n *  " + base.MostrarCalificacion() + "*";
            marco += "\n **************************************";
            return marco;
        }
    }
}
