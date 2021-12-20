using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Strategy;

namespace TP5
{
    class Alumno : IAlumno
    {
        public Alumno()
        {
            //Console.WriteLine("Alumno Real");
            estrategiaDeAlumnosComparables = new EstrategiaPorPromedio();
        }

        double _promedio;
        int _calificacion;
        int _legajo;
        private EstrategiaDeAlumnosComparables estrategiaDeAlumnosComparables;

        //public EstrategiaDeAlumnosComparables EstrategiaDeAlumnosComparables
        //{
        //    get => estrategiaDeAlumnosComparables;
        //    set => estrategiaDeAlumnosComparables = value;
        //}

        public override double Promedio
        {
            get
            {
                return _promedio;
            }
            set
            {
                _promedio = value;
            }
        }
        public override int Calificacion
        {
            get
            {
                return _calificacion;
            }
            set
            {
                _calificacion = value;
            }
        }
        public override int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }

        public override int ResponderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }

        public override EstrategiaDeAlumnosComparables GetEstrategia()
        {
            return this.estrategiaDeAlumnosComparables;
        }

        public override void SetEstrategia(EstrategiaDeAlumnosComparables estrategia)
        {
            this.estrategiaDeAlumnosComparables = estrategia;
        }

        public override string MostrarCalificacion()
        {
            return Calificacion.ToString();
        }
        public override bool sosIgual(IComparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return estrategiaDeAlumnosComparables.sosIgual(this, elemento);
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
    }
}