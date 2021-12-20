using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public interface Coleccionable
    {
        int cuantos();
        Comparable Minimo();
        Comparable Maximo();

        void Agregar(Comparable objeto);
        bool contiene(Comparable objeto);
    }
}
