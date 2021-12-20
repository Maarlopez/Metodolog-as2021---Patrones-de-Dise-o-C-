using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Decorator;
using TP6.Strategy;

namespace TP6.Factory_Method
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override IComparable CrearComparable()
        {
            IAlumno alumno = null;
            alumno = new Alumno
            {
                Nombre = Helper.nombreRandom(),
                Dni = new Random().Next(1000),
                Legajo = new Random().Next(1000)
                //EstrategiaDeAlumnosComparables = new EstrategiaPorCalificacion(),
            };
            alumno = new LegajoDecorator(alumno);
            alumno = new NotaLetrasDecorator(alumno);
            alumno = new NotaAprobacion(alumno);
            alumno = new NotaIndice(alumno);
            alumno = new NotaMarco(alumno);
            alumno.SetEstrategia(new EstrategiaPorCalificacion());
            return alumno;
        }
    }
}
