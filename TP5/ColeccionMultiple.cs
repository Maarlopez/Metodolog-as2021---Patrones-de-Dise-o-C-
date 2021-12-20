using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Iterator;

namespace TP5
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

        List<IComparable> elementos = new List<IComparable>();

        public void agregar(Coleccionable elemento)
        {
        }

        public void Agregar(IComparable objeto)
        {
            ((Coleccionable)pila).Agregar(objeto);
        }

        public bool Contiene(IComparable elementos)
        {
            return pila.Contiene(elementos) || cola.Contiene(elementos);

        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public IComparable Maximo()
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
        public IComparable Minimo()
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

        public Iterador crearIterador()
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
