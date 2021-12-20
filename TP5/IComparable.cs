using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public interface IComparable
    {
        bool sosIgual(IComparable comparable);
        bool sosMenor(IComparable comparable);
        bool sosMayor(IComparable comparable);
    }
}
