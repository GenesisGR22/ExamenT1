using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1
{
    public class PokerGame
    {
        public void Jugar(List<Jugador> jugadores) {

               

                if (jugadores.Count >= 2 && jugadores.Count < 6)
                {
                
            }
                else
                throw new Exception("Mensaje.", null);


        }
    }
}
