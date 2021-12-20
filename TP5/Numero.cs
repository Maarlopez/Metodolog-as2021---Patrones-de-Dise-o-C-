using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Numero : IComparable
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

        public bool sosIgual(IComparable elemento)
        {
            return this.valor == ((Numero)elemento).valor;
        }

        public bool sosMenor(IComparable elemento)
        {
            return this.valor > ((Numero)elemento).valor;
        }

        public bool sosMayor(IComparable elemento)
        {
            return this.valor < ((Numero)elemento).valor;
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
