using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.Strategy;

namespace TP3.Factory_Method
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            return new Alumno
            {
                Nombre = Helper.nombreRamdom(),
                Dni = new Random().Next(1000),
                Legajo = new Random().Next(1000),
                EstrategiaDeComparacionActual = new EstrategiaPorDni(),
            };
        }
    }
}
