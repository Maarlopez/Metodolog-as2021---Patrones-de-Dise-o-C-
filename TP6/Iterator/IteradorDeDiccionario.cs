using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Iterator
{
    public class IteradorDeDiccionario : Iterador
    {
            Diccionario diccionario;
            int posicionActual = 0;
            private List<IComparable> elementos;

            public IteradorDeDiccionario(Diccionario _diccionario)
            {
                this.diccionario = _diccionario;
            }

            public IteradorDeDiccionario(List<IComparable> elementos)
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

