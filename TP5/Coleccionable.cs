using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Iterator;

namespace TP5
{
    public interface Coleccionable: Iterable
    {
        int cuantos();
        IComparable Minimo();
        IComparable Maximo();

        void Agregar(IComparable objeto);
        bool Contiene(IComparable objeto);
        Iterador crearIterador();
    }
}
