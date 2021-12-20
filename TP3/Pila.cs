using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Iterator;

namespace TP3
{
    public class Pila : Coleccionable, Iterable
    {

        public List<Comparable> elementos = new List<Comparable>();
        public void Agregar(Comparable elemento)
        {
            elementos.Add(elemento);
        }

        public bool vacia()
        {
            return elementos.Count == 0;
        }
        public bool Contiene(Comparable elemento)
        {
            foreach (Comparable elemen in elementos)
            {
                if (elemen.sosIgual(elemento))
                    return true;
            }
            return false;
        }

        public int cuantos()
        {
            return elementos.Count;
        }
        public Comparable Minimo()
        {
            Comparable minimo = null;
            if (elementos.Count > 0)
                minimo = elementos[0];

            foreach (Comparable elemento in elementos)
            {
                if (minimo.sosMenor(elemento))
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        public Comparable Maximo()
        {
            Comparable maximo = null;
            if (elementos.Count > 0)
                maximo = elementos[0];

            foreach (Comparable elemento in elementos)
            {
                if (maximo.sosMayor(elemento))
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        }

        public bool Pertenece(Comparable objeto)
        {
            throw new NotImplementedException();
        }

        public void primero()
        {
            throw new NotImplementedException();
        }

        public void siguiente()
        {
            throw new NotImplementedException();
        }

        public bool fin()
        {
            throw new NotImplementedException();
        }

        public object actual()
        {
            throw new NotImplementedException();
        }
    }
}
