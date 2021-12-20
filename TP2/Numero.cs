using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Numero : Comparable
    {
        public int valor;
        public Numero(int valor)
        {
            this.valor = valor;
        }
        public Numero()
        {
        }
        public int GetValor()
        {
            return valor;
        }

        public bool sosIgual(Comparable elemento)
        {
            return this.valor == ((Numero)elemento).valor;
        }

        public bool sosMenor(Comparable elemento)
        {
            return this.valor > ((Numero)elemento).valor;
        }

        public bool sosMayor(Comparable elemento)
        {
            return this.valor < ((Numero)elemento).valor;
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
