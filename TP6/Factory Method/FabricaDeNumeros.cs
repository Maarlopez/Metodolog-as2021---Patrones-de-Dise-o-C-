using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6.Factory_Method
{
    public class FabricaDeNumeros: FabricaDeComparables
    {
        public override IComparable CrearComparable()
        {
            return new Numero { valor = new Random().Next(1000) };
        }
    }
}
