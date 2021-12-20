using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Iterator
{
    public interface Iterador
    {
        //[Interfaz que decide las operaciones que se pueden realizar sobre una coleccion]
        public void primero();
        public void siguiente();
        public bool fin();
        public object actual();

    }
}
