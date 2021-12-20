using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Observer
{
    interface Subject
    {
        public void Agregar(IObserver o);
        public abstract void Notificar();
        public abstract void Quitar(IObserver o);
    }
}
