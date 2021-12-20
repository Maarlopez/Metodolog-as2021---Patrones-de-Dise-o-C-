using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Strategy;

namespace TP6.Factory_Method
{
    public class FabricaDeVendedores : FabricaDeComparables
    {
        public override IComparable CrearComparable()
        {
            return new Vendedor
            {
                Nombre = Helper.nombreRandom(),
                Dni = new Random().Next(1000)
            };
        }
    }
}
