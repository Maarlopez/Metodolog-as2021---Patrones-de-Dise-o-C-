using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Iterator
{
    public class Cola : Coleccionable
    {

        public List<Comparable> elementos = new List<Comparable>();

        public Cola()
        {
        }

        public Iterador crearIterador()
        {
            return new IteradorDeCola(this);
        }

        public Cola(List<Comparable> elementos)
        {
            this.elementos = elementos;
        }

        public bool esVacia()
        {
            return this.elementos.Count == 0;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public void Agregar(Comparable elem)
        {
            elementos.Add(elem);
        }

        public bool Contiene(Comparable elemento)
        {
            return elementos.Contains(elemento);
        }

        public Comparable Maximo()
        {
           Comparable maximo = null;
           if (elementos.Count > 0)
            maximo = elementos[0];
            foreach (Comparable elemen in elementos)
            {
                if (maximo.sosMayor(elemen))
                    maximo = elemen;
            }
                return maximo;
            }

        public Comparable Minimo()
        {
                Comparable minimo = null;
                if (elementos.Count > 0)
                    minimo = elementos[0];
                foreach (Comparable elemen in elementos)
                {
                    if (minimo.sosMenor(elemen))
                        minimo = elemen;
                }
                return minimo;
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
