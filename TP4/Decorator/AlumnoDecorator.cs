using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4.Decorator
{
    abstract class AlumnoDecorator : AlumnoAbstracto
    {
        protected AlumnoAbstracto _alumnoComponent;
        public AlumnoDecorator(AlumnoAbstracto alumnoComponent)
        {
            _alumnoComponent = alumnoComponent;
        }

        public override EstrategiaDeAlumnosComparables GetEstrategia()
        {
            return _alumnoComponent.GetEstrategia();
        }
        public override void SetEstrategia(EstrategiaDeAlumnosComparables estrategia)
        {
            _alumnoComponent.SetEstrategia(estrategia);
        }
        public override bool sosIgual(Comparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return GetEstrategia().sosIgual(this, elemento);
        }

        public override bool sosMenor(Comparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return GetEstrategia().sosMenor(this, elemento);
        }

        public override bool sosMayor(Comparable elemento)
        {
            // estoy restornando un autoproperty que va a ser declarado en al case concreta
            return GetEstrategia().sosMayor(this, elemento);
        }

        public override int ResponderPregunta(int pregunta)
        {
            return _alumnoComponent.ResponderPregunta(pregunta);
        }

        public override string MostrarCalificacion()
        {
            return this._alumnoComponent.MostrarCalificacion();
        }

        public override int Promedio
        {
            get
            {
                return _alumnoComponent.Promedio;
            }
            set
            {
                _alumnoComponent.Promedio = value;
            }
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Dni:" + Dni + ", legajo: " + Legajo;
        }

        public override int Legajo
        {
            get
            {
                return _alumnoComponent.Legajo;
            }
            set
            {
                _alumnoComponent.Legajo = value;
            }
        }

        public override int Calificacion
        {
            get
            {
                return _alumnoComponent.Calificacion;
            }
            set
            {
                _alumnoComponent.Calificacion = value;
            }
        }
        public override int Dni
        {
            get
            {
                return _alumnoComponent.Dni;
            }
            set
            {
                _alumnoComponent.Dni = value;
            }
        }
        public override string Nombre
        {
            get
            {
                return _alumnoComponent.Nombre;
            }
            set
            {
                _alumnoComponent.Nombre = value;
            }
        }
    }
}
