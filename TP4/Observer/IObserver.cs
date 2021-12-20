using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Observer
{
    public interface IObserver //Suscriptores
    {
        public void Update(object o);
    }
}
