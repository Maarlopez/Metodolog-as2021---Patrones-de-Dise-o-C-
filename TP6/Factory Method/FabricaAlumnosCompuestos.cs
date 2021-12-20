using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP6.Proxy;
using TP6.Strategy;

namespace TP6.Factory_Method
{
    public class FabricaAlumnosCompuestos : FabricaDeComparables
    {
        public override IComparable CrearComparable()
        {
            AlumnoComposite alumnoComposite = new AlumnoComposite();
            for(int i= 0; i<5; i++)
            {
                IAlumno alumno = new Alumno
                {
                    Nombre = Helper.nombreRandom(),
                    Dni = new Random().Next(1000),
                    Legajo = new Random().Next(1000),
                    Calificacion = new Random().Next(1000),
                    estrategiaDeAlumnosComparables = new EstrategiaPorCalificacion(),
                };
                alumnoComposite.agregarHijo(alumno);
            }
            
            //alumno.SetEstrategia(new EstrategiaPorNombre());
            return alumnoComposite;
        }
    }
}
