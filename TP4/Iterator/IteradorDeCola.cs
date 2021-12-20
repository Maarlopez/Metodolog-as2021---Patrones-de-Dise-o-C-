using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Iterator;

namespace TP4
{
    public class IteradorDeCola : Iterador
    {
        Cola _cola;
        int posicionActual = 0;
        private List<Comparable> elementos;

        public IteradorDeCola(Cola cola)
        {
            this._cola = cola;
        }

        public IteradorDeCola(List<Comparable> elementos)
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
