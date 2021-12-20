using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    public class ClaveValor: IComparable
    {
        private IComparable clave;
        private IComparable valor;

        public ClaveValor()       
        {
        }
        public ClaveValor(IComparable clave, IComparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public IComparable getClave()
        {
            return clave;
        }

        public IComparable getValor()
        {
            return valor;
        }

        public void setValor(IComparable elemento)
        {
            this.valor = elemento;
        }

        public bool sosIgual(IComparable c)
        {
            return this.clave.sosIgual(((ClaveValor)c).getClave());
        }

        public bool sosMayor(IComparable c)
        {
            return this.clave.sosMayor(((ClaveValor)c).getClave());
        }

        public bool sosMenor(IComparable c)
        {
            return this.clave.sosMenor(((ClaveValor)c).getClave());
        }
    }
}
