using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Pila : Coleccionable
    {

        List<Comparable> elementos = new List<Comparable>();
        public void Agregar(Comparable elemento)
        {
            elementos.Add(elemento);
        }

        public bool contiene(Comparable elemento)
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
    }
}
