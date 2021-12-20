using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Iterator;
using TP4.Strategy;

namespace TP4
{
    class PIterator
    {
        public static void Run()
        {
            Coleccionable UnColeccion = new Cola();
            llenarAlumnos(UnColeccion, new EstrategiaPorLegajo());
            Helper.Informar(UnColeccion);
            Helper.ImprimirElementos(UnColeccion);
        }

        public static Coleccionable llenarAlumnos(Coleccionable coleccionable)
        {
            List<Comparable> comparablesList = new List<Comparable>();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(
                    new AlumnoConcreto
                    {
                        Nombre = Helper.nombreRandom(),
                        Dni = new Random().Next(1000),
                        Legajo = new Random().Next(1000),
                    });
            }
            return coleccionable;
        }
        public static Coleccionable llenarAlumnos(Coleccionable coleccionable, EstrategiaDeAlumnosComparables estrategia)
        {
            List<Comparable> comparablesList = new List<Comparable>();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(
                    new AlumnoConcreto
                    {
                        Nombre = Helper.nombreRandom(),
                        Dni = new Random().Next(1000),
                        Legajo = new Random().Next(1000),
                        estrategiaDeAlumnosComparables = estrategia
                    });
            }
            return coleccionable;
        }

        public static void cambiarEstrategia(Coleccionable coleccionable, 
            EstrategiaDeAlumnosComparables estrategiaDeComparacion)
        {
            var iter = coleccionable.crearIterador();
            while (!iter.fin())
            {
                ((AlumnoConcreto)iter.actual()).estrategiaDeAlumnosComparables = estrategiaDeComparacion;
                iter.siguiente();
            }
        }
    }
}
