using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4
{
    class AlumnoConcreto : AlumnoAbstracto
    {
        int _promedio;
        int _calificacion;
        int _legajo;
        public EstrategiaDeAlumnosComparables estrategiaDeAlumnosComparables;

        public override bool sosIgual(Comparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return estrategiaDeAlumnosComparables.sosIgual(this, elemento);
        }

        public override bool sosMenor(Comparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return estrategiaDeAlumnosComparables.sosMenor(this, elemento);
        }

        public override bool sosMayor(Comparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return estrategiaDeAlumnosComparables.sosMayor(this, elemento);
        }
        public override int Promedio
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
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Dni:" + Dni + ", legajo: " + Legajo;
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
    }
}