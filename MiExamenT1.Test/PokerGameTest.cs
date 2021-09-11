using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1.Test
{
    public class PokerGameTest
    {


        [Test]
        public void Caso01() //minimo de 2 jugadores
        {
            var juego = new PokerGame();
            Assert.Throws(typeof(Exception), () => juego.Jugar(new List<Jugador>()));
        }
        [Test]
        public void Caso02() //max de 5 jugadores
        {
            var juego = new PokerGame();
            var jugadores = new List<Jugador>();
            jugadores.Add(new Jugador { Id= 1, Nombre = "j1"}); 
            jugadores.Add(new Jugador { Id= 2, Nombre = "j2"}); 
            jugadores.Add(new Jugador { Id= 3, Nombre = "j3"}); 
            jugadores.Add(new Jugador { Id= 4, Nombre = "j4"}); 
            jugadores.Add(new Jugador { Id= 5, Nombre = "j5"}); 
            jugadores.Add(new Jugador { Id= 6, Nombre = "j6"}); 
            Assert.Throws(typeof(Exception), () => juego.Jugar(jugadores));
        }
    }
}
