using TP7.Strategy;

namespace TP7
{
   public abstract class IAlumno : Persona
   {
        public abstract EstrategiaDeAlumnosComparables GetEstrategia();
        public abstract void SetEstrategia(EstrategiaDeAlumnosComparables estrategia);

        public abstract double Promedio { get; set; }
        public abstract int Calificacion { get; set; }
        public abstract int Legajo { get; set; }
        public abstract int ResponderPregunta(int pregunta);
        public abstract string MostrarCalificacion();

        public abstract override bool sosIgual(IComparable elemento);

        public abstract override bool sosMenor(IComparable elemento);

        public abstract override bool sosMayor(IComparable elemento);

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Dni:" + Dni + ", legajo: " + Legajo;
        }
    }
}
