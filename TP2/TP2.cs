using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Iterator;
using TP2.Strategy;

namespace TP2
{
    class TP2
    {
        public static int CantChar { get; private set; }

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
                    new Alumno
                    {
                        Nombre = Helper.nombreRamdom(),
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
                    new Alumno
                    {
                        Nombre = Helper.nombreRamdom(),
                        Dni = new Random().Next(1000),
                        Legajo = new Random().Next(1000),
                        EstrategiaDeComparacionActual = estrategia
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
                ((Alumno)iter.actual()).EstrategiaDeComparacionActual = estrategiaDeComparacion;
                iter.siguiente();
            }
        }
    }
}
