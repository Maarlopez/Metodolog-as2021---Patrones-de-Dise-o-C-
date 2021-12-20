using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Iterator;

namespace TP7
{
    public class Pila : Coleccionable, Iterable, IOrdenable
    {

        public List<IComparable> elementos = new List<IComparable>();
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;
        public void Agregar(IComparable comparable)
        {
            elementos.Add(comparable);

            if (elementos.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar((IAlumno)comparable);

            if (elementos.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
        }

        public bool vacia()
        {
            return elementos.Count == 0;
        }
        public bool Contiene(IComparable elemento)
        {
            foreach (IComparable elemen in elementos)
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
        public IComparable Minimo()
        {
            IComparable minimo = null;
            if (elementos.Count > 0)
                minimo = elementos[0];

            foreach (IComparable elemento in elementos)
            {
                if (minimo.sosMenor(elemento))
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        public IComparable Maximo()
        {
            IComparable maximo = null;
            if (elementos.Count > 0)
                maximo = elementos[0];

            foreach (IComparable elemento in elementos)
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

        public bool Pertenece(IComparable objeto)
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

        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }
    }
}
