using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;

namespace TP2
{
    public class IteradorDePila : Iterador
    {
        Pila _pila;
        int posicionActual = 0;

        public List<Comparable> elementos;
        private HashSet<Comparable> elementos1;
        private Dictionary<object, Comparable> elementos2;


        public IteradorDePila(Pila pila)
        {
            this._pila = pila;
        }

        public IteradorDePila(List<Comparable> elementos)
        {
            this.elementos = elementos;
        }

        //public IteradorDePila(List<Comparable> elementos)
        //{
        //    this.elementos = elementos;
        //    posicionActual = elementos.Count - 1;
        //}

        //public IteradorDePila(HashSet<Comparable> elementos1)
        //{
        //    this.elementos1 = elementos1;
        //}

        //public IteradorDePila(Dictionary<object, Comparable> elementos2)
        //{
        //    this.elementos2 = elementos2;
        //}

        public object actual()
        {
            //return _pila.elementos[_pila.elementos.Count - 1 + posicionActual];
            return elementos[posicionActual];
        }

        public bool fin()
        {
            //return this._pila.elementos.Count == posicionActual + 1;

            if (posicionActual < 0)
                return true;
            else
                return false;
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

