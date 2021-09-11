using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1.Test
{
    [TestFixture]
    public class DueloTest
    {

        private List<Jugador> jugadores;
      
        private Duelo duelo;
        [SetUp]
        public void Init()
        {
            jugadores = new List<Jugador>();
        
            duelo = new Duelo();

        }
        [Test]
        public void TestJugadorAGanaPorCartaAlta()
        {

            var jugador1 = new Jugador();
            jugador1.AddJugada(new List<Cartas> {
                new Cartas { Valor = 1, Palo = "Corazon" },
                new Cartas { Valor = 3, Palo = "Diamante" },
                new Cartas { Valor = 7, Palo = "Corazon" },
                new Cartas { Valor = 9, Palo = "Trebol" },
                new Cartas { Valor = 11, Palo = "Corazon" },
            });
            jugadores.Add(jugador1);
            

            var jugador2 = new Jugador(); 
            jugador2.AddJugada(new List<Cartas> {
                new Cartas { Valor = 2, Palo = "Corazon" },
                new Cartas { Valor = 4, Palo = "Diamante" },
                new Cartas { Valor = 6, Palo = "Corazon" },
                new Cartas { Valor = 8, Palo = "Trebol" },
                new Cartas { Valor = 10, Palo = "Corazon" },
            });
            jugadores.Add(jugador2);
            duelo.AgregarDuelo(jugadores);

            Assert.AreEqual("Empate", duelo.GetGanador());
        }

        [Test]
        public void TestJugadorBPorUnPar()
        {
            var jugadorA = new Jugador();
            jugadorA.AddJugada(new List<Cartas> {
                new Cartas { Valor = 1, Palo = "Corazon" },
                new Cartas { Valor = 3, Palo = "Diamante" },
                new Cartas { Valor = 7, Palo = "Corazon" },
                new Cartas { Valor = 9, Palo = "Trebol" },
                new Cartas { Valor = 11, Palo = "Corazon" },
            });
            var jugadorB = new Jugador();
            jugadorB.AddJugada(new List<Cartas> {
                new Cartas { Valor = 2, Palo = "Corazon" },
                new Cartas { Valor = 4, Palo = "Diamante" },
                new Cartas { Valor = 6, Palo = "Corazon" },
                new Cartas { Valor = 8, Palo = "Trebol" },
                new Cartas { Valor = 2, Palo = "Corazon" },
            });

            jugadores.Add(jugadorA);
            jugadores.Add(jugadorB);
            duelo.AgregarDuelo(jugadores);

            Assert.AreEqual("Empate", duelo.GetGanador());
         
        }
        [Test]
        public void caso13()
        {
            
            duelo.AgregarDuelo(jugadores);
            Assert.Throws(typeof(Exception), ()=> duelo.GetGanador());

        }
        [Test]
        public void caso14()
        {
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());
            jugadores.Add(new Jugador());

            duelo.AgregarDuelo(jugadores);
            Assert.Throws(typeof(Exception), () => duelo.GetGanador());

        }
        [Test]
        public void caso15()
        {
            jugadores.Add(new Jugador());
           
            duelo.AgregarDuelo(jugadores);
            Assert.Throws(typeof(Exception), () => duelo.GetGanador());

        }
    }
}
