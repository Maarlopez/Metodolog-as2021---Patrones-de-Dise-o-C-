using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Cola : Coleccionable
    {

        List<Comparable> elementos = new List<Comparable>();

        public Cola()
        {
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

        public bool contiene(Comparable elemento)
            {
                return elementos.Contains(elemento);
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
    }
}
