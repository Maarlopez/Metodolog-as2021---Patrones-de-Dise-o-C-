using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7;

namespace TP7
{
    public class GeneradorDeDatosAleatorios : Manejador
    {
        private static GeneradorDeDatosAleatorios instance = null;
        public GeneradorDeDatosAleatorios(Manejador siguiente) : base(siguiente) { }
        public static GeneradorDeDatosAleatorios GetInstance(Manejador siguiente)
        {
            if (instance == null)
                instance = new GeneradorDeDatosAleatorios(siguiente);
            return instance;
        }
        public int numeroAleatorio() // Devuelve un número aleatorio entre 0 y "max"
        {
            Random rnd = new Random();
            int maxValue = 5000;
            int numAletorio = rnd.Next(0, maxValue);
            return 0;
        }

        override public string stringAleatorio(int cantCaracter)
        {
            string cant = "abcdefghijklmnopqrstuvwxyz";
            string palAleatorio = "";
            char[] letra = new char[cantCaracter];

            Random indiceAleatorio = new Random();

            for (int i = 0; i < cantCaracter; i++)
                letra[i] = cant[indiceAleatorio.Next(0, cant.Length)];

            for (int i = 0; i < letra.Length; i++)
                palAleatorio += letra[i];

            return palAleatorio;
        }
    }
}
