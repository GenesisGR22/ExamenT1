using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1
{
    public class Jugador
    {
        public List<Cartas> cartas;
        public void AddJugada(List<Cartas> cartas)
        {
            this.cartas = cartas;
        }

    }
}
