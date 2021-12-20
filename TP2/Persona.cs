using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Persona : Comparable
    {
        public Persona(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }
        public Persona() { }

        public int Dni { get; set; }
        public string Nombre { get; set; }

        public virtual bool sosIgual(Comparable elemento)
        {
            return this.Dni == ((Persona)elemento).Dni;
        }

        public virtual bool sosMenor(Comparable elemento)
        {
            return this.Dni > ((Persona)elemento).Dni;
        }

        public virtual  bool sosMayor(Comparable elemento)
        {
            return this.Dni < ((Persona)elemento).Dni;
        }

        public override string ToString()
        {
        return "Nombre: " + Nombre + " DNI: " + Dni;
        }


        public int CompareTo(Persona other)
        {
            if (Dni > other.Dni)
                return -1;
            else if (Dni < other.Dni)
                return 1;
            else return 0;
        }
    }
}   