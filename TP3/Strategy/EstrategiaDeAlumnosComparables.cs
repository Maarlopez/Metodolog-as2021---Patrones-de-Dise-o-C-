using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Strategy
{
    public interface EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(Comparable elemento, Comparable elemento2);

        public bool sosMayor(Comparable elemento, Comparable elemento2);

        public bool sosMenor(Comparable elemento, Comparable elemento2);

        public void llamarComparacion(string ValorP);
    }
}
