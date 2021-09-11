using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1
{
    public class Duelo
    {
        private List<Jugador> jugadores;
        //private List<Jugador> jugadorA;
        private Jugador jugadorB;

        private String JugadaGanadora;



        //public void AgregarDuelo(Jugador jugadorA, Jugador jugadorB)
        public void AgregarDuelo(List<Jugador> jugadores)
        {
            this.jugadores = jugadores;
            //this.jugadorB = jugadorB;
        }

        public string GetGanador()
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                var jugadaA = GetJugada(jugadores[i].cartas);
                var jugadaB = GetJugada(jugadorB.cartas);


                if (jugadaA.Valor > jugadaB.Valor)
                {
                    JugadaGanadora = jugadaA.Nombre;
                    return "Jugador A";
                }
                else if (jugadaA.Valor == jugadaB.Valor)
                {
                    return "Empate";
                }
                JugadaGanadora = jugadaB.Nombre;
            }
            //var jugadaA = GetJugada(jugadores.cartas);
            
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
    }
}
