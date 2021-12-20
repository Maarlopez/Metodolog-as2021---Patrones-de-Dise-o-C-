using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Decorator;
using TP4.Strategy;

namespace TP4.Factory_Method
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable CrearComparable()
        {
            AlumnoAbstracto alumno = null;
            alumno = new AlumnoConcreto
            {
                Nombre = Helper.nombreRandom(),
                Dni = new Random().Next(1000),
                Legajo = new Random().Next(1000),
                estrategiaDeAlumnosComparables = new EstrategiaPorCalificacion(),
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
