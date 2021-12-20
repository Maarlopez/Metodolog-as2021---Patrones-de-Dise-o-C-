using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Decorator;
using TP6.Strategy;

namespace TP6.Factory_Method
{
    public class FabricaDeTodos : FabricaDeComparables
    {
        public override IComparable CrearComparable() 
        {
            AlumnoComposite alumnoComposite = new AlumnoComposite();
            for (int i = 0; i < 5; i++)
            {
                IAlumno alumno = new Alumno
                {
                    Nombre = Helper.nombreRandom(),
                    Dni = new Random().Next(1000),
                    Legajo = new Random().Next(1000),
                    Calificacion = new Random().Next(1000),
                    estrategiaDeAlumnosComparables = new EstrategiaPorCalificacion(),
                };

                alumno = new NotaIndice(alumno);
                alumnoComposite.agregarHijo(alumno);
            }

            //alumno.SetEstrategia(new EstrategiaPorNombre());
            return alumnoComposite;
        }
    }
}
