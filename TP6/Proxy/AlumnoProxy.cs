using System;
using TP6.Strategy;
using TP6.Factory_Method;

namespace TP6.Proxy
{
    public class AlumnoProxy : IAlumno
    {

        private IComparable AlumnoReal;
        private int calificacion;
        private int dni;
        private int legajo;
        private string nombre;
        private double promedio;
        //private int tipo;
        EstrategiaDeAlumnosComparables estrategiaDeAlumnosComparables;

        //EstrategiaDeAlumnosComparables EstrategiaDeAlumnosComparables { get; set; }

        public AlumnoProxy(string n, int d, int l, double p, int t, EstrategiaDeAlumnosComparables estrategia)
        {
            this.nombre = n;
            this.dni = d;
            this.legajo = l;
            this.promedio = p;
            this.estrategiaDeAlumnosComparables = estrategia;
            //this.tipo = t;
        }

        public AlumnoProxy()
        {
        }

        public override string Nombre { get => nombre; set => nombre = value; }
        public override int Dni { get => dni; set => dni = value; }
        public override int Calificacion { get => calificacion; set => calificacion = value; }
        public override int Legajo { get => legajo; set => legajo = value; }
        public override double Promedio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string getNombre()
        {
            if (AlumnoReal == null)
            {
                return nombre;
            }
            else
            {
                return ((Alumno)AlumnoReal).Nombre;
            }
        }
        public int getCalificacion()
        {
            if(AlumnoReal == null)
            {
                return calificacion;
            }
            else
            {
                return ((Alumno)AlumnoReal).Calificacion;
            }
        }

        public int getDni()
        {
            if (AlumnoReal == null)
            {
                return dni;
            }
            else
            {
                return ((Alumno)AlumnoReal).Dni;
            }
        }

        public int getLegajo()
        {
            if (AlumnoReal == null)
            {
                return legajo;
            }
            else
            {
                return ((Alumno)AlumnoReal).Legajo;
            }
        }

        public double getPromedio()
        {
            if (AlumnoReal == null)
            {
                return promedio;
            }
            else
            {
                return ((Alumno)AlumnoReal).Promedio;
            }
        }

        public override int ResponderPregunta(int pregunta)
        {

            if (this.AlumnoReal == null)
            {
               AlumnoReal = FabricaDeComparables.CrearComparable("2");
            }

            return ((IAlumno)AlumnoReal).ResponderPregunta(pregunta);
        }
        public void setCalificacion(int calificacion)
        {
        }
        public override bool sosIgual(IComparable elemento)
        {
            if (AlumnoReal == null)
            {
                return this.sosMayor(elemento);
            }
            else
            {
                return AlumnoReal.sosMayor(elemento);
            }
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
          //  return estrategiaDeAlumnosComparables.sosIgual(this, elemento);
        }

        public override bool sosMenor(IComparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return estrategiaDeAlumnosComparables.sosMenor(this, elemento);
        }

        public override bool sosMayor(IComparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return estrategiaDeAlumnosComparables.sosMayor(this, elemento);
        }
        public override string MostrarCalificacion()
        {
            return getCalificacion().ToString();
        }

        public override EstrategiaDeAlumnosComparables GetEstrategia()
        {
            throw new NotImplementedException();
        }

        public override void SetEstrategia(EstrategiaDeAlumnosComparables estrategia)
        {
            throw new NotImplementedException();
        }
    }
}