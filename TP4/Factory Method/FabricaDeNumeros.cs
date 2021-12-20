using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Factory_Method
{
    public class FabricaDeNumeros: FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Numero { valor = new Random().Next(1000) };
        }
    }
}
