using System;
using System.Collections.Generic;

namespace TP6
{
    public abstract class JuegoDeCartas
    {
        protected int[] mazoCartas = new int[10];
        protected int[] mazoindividual1 = new int[5];
        protected int[] mazoindividual2 = new int[5];
        bool confirmacion = false;

        public Persona jugar(Persona jugador1, Persona jugador2)
        {

            this.mezclarElMazo();
            this.repartirCartas();
            while (!hayGanador(confirmacion))
            {
                for (int i = 0; i < 5; i++)
                {
                    this.tomarCarta(jugador1);
                    this.tomarCarta(jugador2);
                }
                this.descartarCarta(jugador1);
                this.descartarCarta(jugador2);
                if (this.ganador(jugador1, jugador2) == null)
                {
                    confirmacion = false;
                    this.repartirCartas();
                }
                else
                    confirmacion = true;
            }
            return ganador(jugador1, jugador2);
        }

        public abstract void mezclarElMazo();
        public abstract void repartirCartas();
        public abstract void tomarCarta(Persona Jugador);
        public abstract void descartarCarta(Persona Jugador);
        public abstract bool hayGanador(bool confirmacion);
        public abstract Persona ganador(Persona jugador1, Persona jugador2);

    }

    public class SumandoCartas : JuegoDeCartas
    {
        Random cartaAleatoria = new Random();

        public override void mezclarElMazo()
        {

            Console.WriteLine("Jugando al Sumador de cartas ...");
            Console.WriteLine("Mezclando mazo...");
            for (int i = 0; i < mazoCartas.Length; i++)
            {
                int carta = cartaAleatoria.Next(1, 11);
                mazoCartas[i] = carta;
            }
        }

        public override void repartirCartas()
        {

            Console.WriteLine("Repartiendo Cartas... ");
            Random indicesAzar = new Random();

            for (int i = 0; i < 5; i++)
                mazoindividual1[i] = mazoCartas[indicesAzar.Next(0, 10)];

            for (int j = 0; j < 5; j++)
                mazoindividual2[j] = mazoCartas[indicesAzar.Next(0, 10)];
        }

        public override void tomarCarta(Persona Jugador)
        {
            Console.WriteLine("El jugador: " + Jugador.Nombre + ", esta tomando una carta...");
        }

        public override void descartarCarta(Persona Jugador)
        {

            Console.WriteLine("El jugador: " + Jugador.Nombre + ", esta descartando cartas...");

        }

        public override Persona ganador(Persona jugador1, Persona jugador2)
        {

            //Sumar todas las cartas del mazo, retorna la persona que gano
            int totalMazo1 = 0;
            int totalMazo2 = 0;


            for (int j = 0; j < mazoindividual1.Length; j++)
                totalMazo1 += mazoindividual1[j];

            for (int i = 0; i < mazoindividual2.Length; i++)
                totalMazo2 += mazoindividual2[i];

            if (totalMazo1 > totalMazo2)
            {
                hayGanador(true);
                return jugador1;
            }

            if (totalMazo1 < totalMazo2)
            {
                hayGanador(true);
                return jugador2;
            }

            else
            {
                hayGanador(false);
                return null;
            }

        }

        public override bool hayGanador(bool confirmacion)
        {
            return confirmacion;
        }

    }

    public class ContandoCartasPares : JuegoDeCartas
    {
        Random cartaAleatoria = new Random();

        public override void mezclarElMazo()
        {

            Console.WriteLine("Jugando a Contador de cartas pares...");
            Console.WriteLine("Mezclando mazo...");
            for (int i = 0; i < mazoCartas.Length; i++)
            {
                int carta = cartaAleatoria.Next(1, 11);
                mazoCartas[i] = carta;
            }
        }

        public override void repartirCartas()
        {

            Console.WriteLine("Repartiendo Cartas... ");
            Random indicesAzar = new Random();

            for (int i = 0; i < 5; i++)
                mazoindividual1[i] = mazoCartas[indicesAzar.Next(0, 10)];

            for (int j = 0; j < 5; j++)
                mazoindividual2[j] = mazoCartas[indicesAzar.Next(0, 10)];

        }

        public override void tomarCarta(Persona Jugador)
        {
            Console.WriteLine("El jugador: " + Jugador.Nombre + ", esta tomando una carta...");
        }

        public override void descartarCarta(Persona Jugador)
        {
            Console.WriteLine("El jugador: " + Jugador.Nombre + ", esta descartando cartas...");
        }

        public override Persona ganador(Persona jugador1, Persona jugador2)
        {

            //retornar la persona que gano
            int totalPunto1 = 0;
            int totalPunto2 = 0;
            bool confirmacion = true;

            for (int j = 0; j < mazoindividual1.Length; j++)
                if (mazoindividual1[j] % 2 == 0)
                    totalPunto1++;

            for (int i = 0; i < mazoindividual2.Length; i++)
                if (mazoindividual2[i] % 2 == 0)
                    totalPunto2++;

            if (totalPunto1 > totalPunto2)
            {
                hayGanador(confirmacion);
                return jugador1;
            }

            if (totalPunto1 < totalPunto2)
            {
                hayGanador(confirmacion);
                return jugador2;
            }

            else
            {
                hayGanador(false);
                return null;
            }
        }

        public override bool hayGanador(bool confirmacion)
        {
            return confirmacion;
        }


    }


}
