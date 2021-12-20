using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4.Factory_Method
{
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new AlumnoMuyEstudioso
            {
                Nombre = Helper.nombreRandom(),
                Dni = new Random().Next(1000),
                Legajo = new Random().Next(1000),
                EstrategiaDeComparacionActual = new EstrategiaPorCalificacion(),
            };
        }
    }
}
