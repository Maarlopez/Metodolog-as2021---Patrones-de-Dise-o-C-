using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Iterator;

namespace TP5
{
    public class Diccionario: Coleccionable, IOrdenable
    {
        
        public List<ClaveValor> coleccion;
        private List<IComparable> diccionario;
        IOrdenEnAula1 ordenInicio = null;
        IOrdenEnAula1 ordenAulaLlena = null;
        IOrdenEnAula2 ordenLlegaAlumno = null;
        public Diccionario()
        {
            coleccion = new List<ClaveValor>();
        }
        public bool Pertenece(System.IComparable elemento)
        {
            return Contiene((IComparable)elemento);
        }
        public void Agregar(IComparable comparable)
        {
            if (!Pertenece((System.IComparable)comparable))
                diccionario.Add(comparable);

            if (diccionario.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar((IAlumno)comparable);

            if (diccionario.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
        }

        public IComparable valorDe(IComparable clave)
        {
            IComparable valor = null;
            foreach (ClaveValor i in coleccion)
            {
                if (i.sosIgual(clave))
                {
                    valor = (IComparable)i.getValor();
                }
            }
            return valor;
        }

        public List<ClaveValor> getDiccionario()
        {
            return coleccion;
        }

        public bool Contiene(IComparable objeto)
        {
            return coleccion.Contains(objeto);
        }
        public Iterador crearIterador()
        {
            return new IteradorDeDiccionario(this);
        }

        public int cuantos()
        {
            return coleccion.Count;
        }

        public IComparable Maximo()
        {
            IComparable maximo = null;
            if (coleccion.Count > 0)
                maximo = coleccion[0];
            foreach (IComparable elemen in coleccion)
            {
                if (maximo.sosMayor(elemen))
                    maximo = elemen;
            }
            return maximo;
        }

        public IComparable Minimo()
        {
            IComparable minimo = null;
            if (coleccion.Count > 0)
                minimo = coleccion[0];
            foreach (IComparable elemen in coleccion)
            {
                if (minimo.sosMenor(elemen))
                    minimo = elemen;
            }
            return minimo;
        }

        public IComparable ValorDe(IComparable clave)
        {
            IComparable valor = null;
            foreach (ClaveValor claveValor in coleccion)
            {
                IComparable calveValor = claveValor.getClave();
                if (calveValor.sosIgual(clave))
                {
                    valor = claveValor.getValor();
                    break;
                }
                    
            }
            return valor;
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
