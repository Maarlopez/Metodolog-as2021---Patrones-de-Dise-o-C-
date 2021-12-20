using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Iterator
{
    public class Cola : Coleccionable,IOrdenable
    {

        public List<IComparable> elementos = new List<IComparable>();
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;
        public Cola()
        {
        }

        public Iterador crearIterador()
        {
            return new IteradorDeCola(this);
        }

        public Cola(List<IComparable> elementos)
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

        public bool Contiene(IComparable elemento)
        {
            return elementos.Contains(elemento);
        }

        public IComparable Maximo()
        {
           IComparable maximo = null;
           if (elementos.Count > 0)
            maximo = elementos[0];
            foreach (IComparable elemen in elementos)
            {
                if (maximo.sosMayor(elemen))
                    maximo = elemen;
            }
                return maximo;
            }

        public IComparable Minimo()
        {
                IComparable minimo = null;
                if (elementos.Count > 0)
                    minimo = elementos[0];
                foreach (IComparable elemen in elementos)
                {
                    if (minimo.sosMenor(elemen))
                        minimo = elemen;
                }
                return minimo;
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
            throw new NotImplementedException();
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            throw new NotImplementedException();
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            throw new NotImplementedException();
        }
    }
}
