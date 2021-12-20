using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class ClaveValor: Comparable
    {
        private Comparable clave;
        private Comparable valor;

        public ClaveValor()       
        {
        }
        public ClaveValor(Comparable clave, Comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public Comparable getClave()
        {
            return clave;
        }

        public Comparable getValor()
        {
            return valor;
        }

        public void setValor(Comparable elemento)
        {
            this.valor = elemento;
        }

        public bool sosIgual(Comparable c)
        {
            return this.clave.sosIgual(((ClaveValor)c).getClave());
        }

        public bool sosMayor(Comparable c)
        {
            return this.clave.sosMayor(((ClaveValor)c).getClave());
        }

        public bool sosMenor(Comparable c)
        {
            return this.clave.sosMenor(((ClaveValor)c).getClave());
        }
    }
}
