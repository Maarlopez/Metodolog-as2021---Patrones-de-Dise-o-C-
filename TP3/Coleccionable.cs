using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Iterator;

namespace TP3
{
    public interface Coleccionable: Iterable
    {
        int cuantos();
        Comparable Minimo();
        Comparable Maximo();

        void Agregar(Comparable objeto);
        bool Contiene(Comparable objeto);
        Iterador crearIterador();
    }
}
