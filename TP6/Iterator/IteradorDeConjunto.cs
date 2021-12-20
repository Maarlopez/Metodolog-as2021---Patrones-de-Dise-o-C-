using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Iterator
{
    class IteradorDeConjunto: Iterador
    {
        Conjunto _conjunto;
        int posicionActual = 0;
        private List<IComparable> elementos;

        public IteradorDeConjunto(Conjunto conjunto)
        {
            this._conjunto = conjunto;
        }
        public object actual()
        {
            return this._conjunto.elementos2[posicionActual];
        }

        public bool fin()
        {
            return this._conjunto.elementos2.Count == posicionActual;
        }


        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }
    }
}
