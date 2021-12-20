using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Iterator
{
    public interface Iterable
    {
        public Iterador crearIterador(); //Este metodo retorna un Iterador, es decir va a retornar un
                                         //objeto de una clase que implemente la interfaz Iterador
    }
}
