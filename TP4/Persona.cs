using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Persona : Comparable
    {
        public Persona(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }
        public Persona() { }

        public virtual int Dni { get; set; }
        public virtual string Nombre { get; set; }

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
            return "Nombre: " + Nombre + ", Dni:" + Dni.ToString();
        }
    }
}   