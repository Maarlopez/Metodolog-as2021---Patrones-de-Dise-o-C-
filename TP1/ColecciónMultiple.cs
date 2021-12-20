using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class ColeccionMultiple : Coleccionable
    {

        Pila pila;
        Cola cola;
        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        List<Comparable> elementos = new List<Comparable>();

        public void agregar(Coleccionable elemento)
        {
        }

        public void Agregar(Comparable objeto)
        {
            ((Coleccionable)pila).Agregar(objeto);
        }

        public bool contiene(Comparable elementos)
        {
            return pila.contiene(elementos) || cola.contiene(elementos);

        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public Comparable Maximo()
        {
            if (pila.Maximo().sosMenor(cola.Maximo()))
            {
                return pila.Maximo();
            }

            else
            {
                return cola.Maximo();
            }
        }
        public Comparable Minimo()
        {
            if (pila.Minimo().sosMenor(cola.Minimo()))
            {
                return cola.Minimo();
            }

            else
            {
                return pila.Minimo();
            }

        }
    }
}
