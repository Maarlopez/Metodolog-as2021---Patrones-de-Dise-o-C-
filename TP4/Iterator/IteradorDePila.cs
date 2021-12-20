using System.Collections.Generic;
using TP4.Iterator;

namespace TP4
{
    public class IteradorDePila : Iterador
    {
        Pila _pila;
        int posicionActual = 0;

        public List<Comparable> elementos;
        //private HashSet<Comparable> elementos1;
        //private Dictionary<object, Comparable> elementos2;


        public IteradorDePila(Pila pila)
        {
            this._pila = pila;
            elementos = pila.elementos;
        }

        public object actual()
        {
            //return _pila.elementos[_pila.elementos.Count - 1 + posicionActual];
            return elementos[posicionActual];
        }

        public bool fin()
        {
            return this.elementos.Count == posicionActual + 1;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }

        public void inicial()
        {
            posicionActual = elementos.Count;
        }
    }
}