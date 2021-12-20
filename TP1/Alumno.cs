using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Alumno : Persona
    {
        public int legajo;
        public double promedio;

        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            Legajo = legajo;
            Promedio = promedio;
        }
        //--------------------------PROPIEDADES--------------------------//
        public int DNI { get; set; }
        public int Legajo { get; set; }
        public double Promedio { get; set; }
        public string nombre { get; set; }

        //--------------------------PROPIEDADES--------------------------//

        public new bool sosIgual(Comparable elemento)
        {
            return this.legajo == ((Alumno)elemento).Legajo;
        }

        public new bool sosMayor(Comparable elemento)
        {
            return this.legajo > ((Alumno)elemento).Legajo;
        }

        public new bool sosMenor(Comparable elemento) => this.legajo < ((Alumno)elemento).Legajo;

        //public override string ToString()
        //{
        //    //return (legajo=212223, promedio=7.2).ToString();
        //    return (legajo, promedio).ToString();
        //}
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Dni:" + Dni + ", legajo: " + Legajo;
        }
    }
}
