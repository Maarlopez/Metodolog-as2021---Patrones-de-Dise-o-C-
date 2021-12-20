using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Strategy;

namespace TP7
{
    public class AlumnoComposite : IAlumno
    {
        private List<IAlumno> hijos = new List<IAlumno>();

        public IComparable AlumnosComposite;
        private int calificacion;
        private int dni;
        private int legajo;
        private string nombre;
        private double promedio;
        public EstrategiaDeAlumnosComparables estrategiaDeAlumnosComparables;

        public override string Nombre
        {
            get
            {
                string nombres = "";
                foreach (IAlumno alumno in hijos)
                {
                    nombres = alumno.Nombre + "\t";
                }
                return nombres;
            }
            set { }
        }
        public override int Dni { get => dni; set => dni = value; }
        public override int Calificacion
        {
            get
            {
                return hijos[0].Calificacion;
            }
            set { }
        }
        public override double Promedio
        {
            get
            {
                return hijos[0].Promedio;
            }
            set { }
        }
        public override int Legajo
        {
            get
            {
                return hijos[0].Legajo;
            }
            set { }
        }

        public void agregarHijo(IAlumno a)
        {
            hijos.Add(a);
        }

        public override EstrategiaDeAlumnosComparables GetEstrategia()
        {
            throw new NotImplementedException();
        }

        public override string MostrarCalificacion()
        {
            string calif = "";
            foreach (IAlumno a in hijos)
                calif += a.MostrarCalificacion() + ", ";

            return calif;
        }

        public override int ResponderPregunta(int pregunta)
        {
            int[] respuestas = new int[] { 0, 0, 0 };

            foreach (IAlumno item in this.hijos)
            {
                int respuesta = item.ResponderPregunta(pregunta);
                respuestas[respuesta]++;
            }
            int max = -1;
            List<int> masVotada = new List<int>();
            for (int i = 1; i < respuestas.Length; i++)
            {
                if (respuestas[i] >= max)
                {
                    masVotada.Add(i);
                }
            }
            Random azar = new Random();
            return masVotada[azar.Next(masVotada.Count)];
        }

        public override void SetEstrategia(EstrategiaDeAlumnosComparables estrategia)
        {
            this.estrategiaDeAlumnosComparables = estrategia;
        }

        public override bool sosIgual(IComparable elemento)
        {
            bool esIgual = false;

            foreach (IAlumno a in hijos)
                if (a.sosIgual(elemento))
                    esIgual = true;

            return esIgual;
            //devuelve true si existe un componente-hijo que sea igual al Alumno recibido por parámetro.
        }

        public override bool sosMayor(IComparable elemento)
        {
            bool esMayor = false;
            foreach (IAlumno a in hijos)
                if (a.sosMayor(elemento))
                    esMayor = true;

            return esMayor;
        }


        public override bool sosMenor(IComparable elemento)
        {
            bool esMenor = false;
            foreach (IAlumno a in hijos)
                if (a.sosMenor(elemento))
                    esMenor = true;

            return esMenor;
        }
    }
}
