using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Iterator;

namespace TP3
{
    public class Diccionario: Coleccionable
    {
        
        public List<ClaveValor> coleccion;

        public Diccionario()
        {
            coleccion = new List<ClaveValor>();
        }
        public void Agregar(Comparable valor)
        {
            bool existe = false;
            
            foreach (ClaveValor i in coleccion)
            {
                if (i.sosIgual(valor))
                {
                    existe = true;
                    i.setValor(valor);
                }
            }
            if (!existe)
            {
                coleccion.Add((ClaveValor)valor);
            }
        }

        public Comparable valorDe(Comparable clave)
        {
            Comparable valor = null;
            foreach (ClaveValor i in coleccion)
            {
                if (i.sosIgual(clave))
                {
                    valor = (Comparable)i.getValor();
                }
            }
            return valor;
        }

        public List<ClaveValor> getDiccionario()
        {
            return coleccion;
        }

        public bool Contiene(Comparable objeto)
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

        public Comparable Maximo()
        {
            Comparable maximo = null;
            if (coleccion.Count > 0)
                maximo = coleccion[0];
            foreach (Comparable elemen in coleccion)
            {
                if (maximo.sosMayor(elemen))
                    maximo = elemen;
            }
            return maximo;
        }

        public Comparable Minimo()
        {
            Comparable minimo = null;
            if (coleccion.Count > 0)
                minimo = coleccion[0];
            foreach (Comparable elemen in coleccion)
            {
                if (minimo.sosMenor(elemen))
                    minimo = elemen;
            }
            return minimo;
        }

        public Comparable ValorDe(Comparable clave)
        {
            Comparable valor = null;
            foreach (ClaveValor claveValor in coleccion)
            {
                Comparable calveValor = claveValor.getClave();
                if (calveValor.sosIgual(clave))
                {
                    valor = claveValor.getValor();
                    break;
                }
                    
            }
            return valor;
        }
    }
}
