using TP4.Strategy;

namespace TP4
{
   abstract class AlumnoAbstracto : Persona
   {
        public abstract EstrategiaDeAlumnosComparables GetEstrategia();
        public abstract void SetEstrategia(EstrategiaDeAlumnosComparables estrategia);

        public abstract int Promedio { get; set; }
        public abstract int Calificacion { get; set; }
        public abstract int Legajo { get; set; }
        public abstract int ResponderPregunta(int pregunta);
        public abstract string MostrarCalificacion();

        public abstract override bool sosIgual(Comparable elemento);

        public abstract override bool sosMenor(Comparable elemento);

        public abstract override bool sosMayor(Comparable elemento);

        public override abstract string ToString();
    }
}
