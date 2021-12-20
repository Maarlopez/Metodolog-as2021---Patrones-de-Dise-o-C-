using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class GeneradorDeDatosAleatorios
    {
        public int numeroAleatorio() // Devuelve un número aleatorio entre 0 y "max"
        {
            Random rnd = new Random();
            int maxValue = 5000;
            int numAletorio = rnd.Next(0, maxValue);
            return 0;
        }

        public string stringAleatorio() //Devuelve un string aleatorio de "cant" caracteres
        {
            string cant = "abcdefghijklmnopqrstuvwxyz";
            string outchar = cant.Substring(new Random().Next(cant.Length - 1), 1);
            return outchar;
        }
    }
}
