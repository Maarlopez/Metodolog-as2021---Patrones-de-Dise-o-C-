using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Proxy;
using TP6.Strategy;

namespace TP6.Factory_Method
{
    public class FabricaDeAlumnosProxy : FabricaDeComparables
    {
        public override IComparable CrearComparable()
        {
            return new AlumnoProxy
            {
                Nombre = Helper.nombreRandom(),
                Dni = new Random().Next(1000),
                Legajo = new Random().Next(1000)
            };
            //EstrategiaDeAlumnosComparables = new EstrategiaPorCalificacion();
        }
    }
}
