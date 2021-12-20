using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Strategy
{
    public interface EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(IComparable elemento, IComparable elemento2);

        public bool sosMayor(IComparable elemento, IComparable elemento2);

        public bool sosMenor(IComparable elemento, IComparable elemento2);

        //public void llamarComparacion(string ValorP);
    }
}
