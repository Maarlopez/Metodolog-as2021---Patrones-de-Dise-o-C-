using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Iterator;
using TP5.Strategy;

namespace TP5
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
            List<IComparable> comparablesList = new List<IComparable>();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(
                    new Alumno
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
            List<IComparable> comparablesList = new List<IComparable>();
            for (int i = 0; i < 20; i++)
            {
                Alumno al = new Alumno
                {
                    Nombre = Helper.nombreRandom(),
                    Dni = new Random().Next(1000),
                    Legajo = new Random().Next(1000),
                };
                //al.SetEstrategia(estrategia);
                coleccionable.Agregar(al);
            }
            return coleccionable;
        }

        public static void cambiarEstrategia(Coleccionable coleccionable, 
            EstrategiaDeAlumnosComparables estrategiaDeComparacion)
        {
            var iter = coleccionable.crearIterador();
            while (!iter.fin())
            {
                ((Alumno)iter.actual()).SetEstrategia(estrategiaDeComparacion);
                iter.siguiente();
            }
        }
    }
}
