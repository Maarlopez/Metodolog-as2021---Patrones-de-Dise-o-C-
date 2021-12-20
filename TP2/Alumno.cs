using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Strategy;

namespace TP2
{
    public class Alumno : Persona
    {
        public EstrategiaDeAlumnosComparables EstrategiaDeComparacionActual;

        double promedio;

        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            Legajo = legajo;
            Promedio = promedio;
            this.EstrategiaDeComparacionActual = new EstrategiaPorLegajo();

        }

        public Alumno()
        {
            this.EstrategiaDeComparacionActual = new EstrategiaPorLegajo();
        }

        //--------------------------PROPIEDADES--------------------------//
        public int Legajo { get; set; }
        public double Promedio { get; set; }

        //--------------------------PROPIEDADES--------------------------//
        public int setEstrategia() { return 0; }
        
        
        public override bool sosIgual(Comparable elemento)
        {
            //return this.Legajo == ((Alumno)elemento).Legajo;
            return this.EstrategiaDeComparacionActual.sosIgual(this, elemento);

        }
        public override bool sosMayor(Comparable elemento)
        {
            //return this.Legajo > ((Alumno)elemento).Legajo;
            return this.EstrategiaDeComparacionActual.sosMayor(this, elemento);
        }

        public override bool sosMenor(Comparable elemento)
        {
            //return this.Legajo < ((Alumno)elemento).Legajo;
            return this.EstrategiaDeComparacionActual.sosMenor(this, elemento);
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", DNI: " + Dni + ", legajo: " + Legajo;
        }
    }
}