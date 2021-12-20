using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Iterator
{
    public class IteradorDeDiccionario : Iterador
    {
            Diccionario diccionario;
            int posicionActual = 0;
            private List<Comparable> elementos;

            public IteradorDeDiccionario(Diccionario _diccionario)
            {
                this.diccionario = _diccionario;
            }

            public IteradorDeDiccionario(List<Comparable> elementos)
            {
                this.elementos = elementos;
            }

            public object actual()
            {
                return this.diccionario.coleccion[posicionActual].getValor();
            }

            public bool fin()
            {
            return this.diccionario.coleccion.Count == posicionActual;
            }

            public void primero()
            {
                posicionActual = 0;
            }

            public void siguiente()
            {
                posicionActual++;
            }
    }
    
}

