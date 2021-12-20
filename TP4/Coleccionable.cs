using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Iterator;

namespace TP4
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
