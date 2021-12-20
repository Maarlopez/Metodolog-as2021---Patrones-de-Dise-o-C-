using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Iterator;

namespace TP4
{
    public class Conjunto: Coleccionable
    {   
        public Conjunto() { }

        public List<Comparable> elementos2 = new List<Comparable>();

        public List<Comparable> getConjunto()
        {
            return elementos2;
        }
        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }

        public void Agregar(Comparable elemento)
        {
            if (!elementos2.Contains(elemento))
                elementos2.Add(elemento);
        }

        public bool Contiene(Comparable elemento)
        {
            foreach (Comparable e in elementos2)
            {
                if (e.sosIgual(elemento))
                {
                    return true;
                }
            }
            return false;
        }
        public int cuantos()
        {
            return elementos2.Count;
        }

        public Comparable Maximo()
        {
            Comparable maximo = null;
            foreach (Comparable elemen in elementos2)
            {
                if (maximo == null)
                    maximo = elemen;
                if (maximo.sosMayor(elemen))
                    maximo = elemen;
            }
            return maximo;
        }

        public Comparable Minimo()
        {
            return null;
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
