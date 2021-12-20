using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Strategy;

namespace TP3.Factory_Method
{
    public class FabricaDeVendedores : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Vendedor
            {
                Nombre = Helper.nombreRamdom(),
                Dni = new Random().Next(1000)
            };
        }
    }
}
