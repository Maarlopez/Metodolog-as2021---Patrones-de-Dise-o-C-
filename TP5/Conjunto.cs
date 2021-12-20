using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Iterator;

namespace TP5
{
    public class Conjunto: Coleccionable, IOrdenable
    {   
        public Conjunto() { }

        public List<IComparable> elementos2 = new List<IComparable>();
        private List<IComparable> conjunto;
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;

        public List<IComparable> getConjunto()
        {
            return elementos2;
        }
        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }
        public bool Pertenece(System.IComparable elemento)
        {
            return Contiene((IComparable)elemento);
        }
        public void Agregar(IComparable comparable)
        {
            if (!Pertenece((System.IComparable)comparable))
                conjunto.Add(comparable);

            if (conjunto.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar((IAlumno)comparable);

            if (conjunto.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
        }

        public bool Contiene(IComparable elemento)
        {
            foreach (IComparable e in elementos2)
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

        public IComparable Maximo()
        {
            IComparable maximo = null;
            foreach (IComparable elemen in elementos2)
            {
                if (maximo == null)
                    maximo = elemen;
                if (maximo.sosMayor(elemen))
                    maximo = elemen;
            }
            return maximo;
        }

        public IComparable Minimo()
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
