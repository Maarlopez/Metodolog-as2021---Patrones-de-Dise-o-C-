using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Iterator;

namespace TP6
{
    public class IteradorDeCola : Iterador
    {
        Cola _cola;
        int posicionActual = 0;
        private List<IComparable> elementos;

        public IteradorDeCola(Cola cola)
        {
            this._cola = cola;
        }

        public IteradorDeCola(List<IComparable> elementos)
        {
            this.elementos = elementos;
        }

        public object actual(Cola cola)
        {
            return this._cola.elementos[posicionActual];
        }

        public object actual()
        {
            return this._cola.elementos[posicionActual];
        }

        public bool fin()
        {
            return this._cola.elementos.Count == posicionActual + 1;
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
