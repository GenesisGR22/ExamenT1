using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1
{
    public class Duelo
    {
        private List<Jugador> jugadores;
 

        private String JugadaGanadora;



       
        public void AgregarDuelo(List<Jugador> jugadores)
        {
            this.jugadores = jugadores;
          
        }

        public string GetGanador()
        {
            menosDeDosJugadores(jugadores);
            masDeCincoJugadores(jugadores);
            var jugadas = new List<Jugada>();
            for (int i = 0; i < jugadores.Count; i++)
            {
                jugadas.Add(GetJugada(jugadores[i].cartas));
               
            }
            var jugada = new Jugada();

            for (int i = 0; i < jugadas.Count; i++)
            {
                for (int j = 0; j < jugadas.Count; j++)
                {
                    if (jugadas[i].Valor > jugadas[j].Valor)
                    {
                        JugadaGanadora = jugadas[i].Nombre;
                        return "Jugador A";
                    }
                    else if (jugadas[i].Valor == jugadas[j].Valor)
                    {
                        jugada.Nombre = "Empate";
                        return "Empate";
                    }
                    JugadaGanadora = jugadas[i].Nombre;
                }
            }


            return "Jugador B";
        }

        private Jugada GetJugada(List<Cartas> cartas)
        {
            var jugada = new PokerGame();

            foreach (var carta in cartas)
            {
                jugada.AddCarta(carta);
            }

            return jugada.GetJugada();

        }

        public string GetJugada()
        {
            return JugadaGanadora;
        }


        public void menosDeDosJugadores(List<Jugador> jugadores)
        {
            if(jugadores.Count < 2)
                throw new Exception(" Debes ser mayor");
        }
        public void masDeCincoJugadores(List<Jugador> jugadores)
        {
            if (jugadores.Count > 5)
                throw new Exception(" Debes ser mayor");
        }
    }
}
