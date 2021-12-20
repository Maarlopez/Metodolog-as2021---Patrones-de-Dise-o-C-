using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;

namespace TP2
{
    public interface Coleccionable : Iterable
    {
        int cuantos();
        Comparable Minimo();
        Comparable Maximo();

        void Agregar(Comparable objeto);
        bool Contiene(Comparable objeto);
        Iterador crearIterador();
    }
}
