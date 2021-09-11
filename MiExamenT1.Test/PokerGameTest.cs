using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiExamenT1.Test
{
    [TestFixture]
    public class PokerGameTest
    {

        private PokerGame juego;

        [SetUp]
        public void Init()
        {
            juego = new PokerGame();
        }

        [Test]
        public void ManoDePokerEsCartaAlta()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 3, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 5, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 7, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Carta Alta", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnDobleDeAses()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 5, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 7, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Un Doble", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnDobleTreces()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 5, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 9, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Un Doble", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnParDeDoblesAsesYTreces()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 5, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Dos Dobles", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnTrioDeAses()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 5, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Trio", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneUnaEscalera()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 3, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 2, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 4, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 5, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneFullHouse()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 1, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Full", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTienePoker()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 1, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Espada" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Poker", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneEscaleraColor()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 1, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 2, Palo = "Corazon" });

            juego.AddCarta(new Cartas { Valor = 3, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 4, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 5, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Escalera Color", juego.GetJugada().Nombre);
        }

        [Test]
        public void ManoDePokerTieneEscaleraReal()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Corazon" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Flor Imperial", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso16()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Trebol" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Flor Imperial", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso17()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "corazon" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso18()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Corazon" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso19()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso20()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Trebol" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso21()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Trebol" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso22()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Corazon " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Corazon" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso23()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Corazon " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso24()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Diamante " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Trebol" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso25()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Corazon " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Trebol" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso26()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Diamante " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Corazon" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Diamante" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso27()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Trebol " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso28()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Diamante " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Trebol" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Trebol" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Corazon" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso29()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Corazon " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Diamante" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
        [Test]
        public void caso30()
        {
            //Act
            juego.AddCarta(new Cartas { Valor = 10, Palo = "Trebol " });
            juego.AddCarta(new Cartas { Valor = 11, Palo = "Corazon" });

            juego.AddCarta(new Cartas { Valor = 12, Palo = "Diamante" });
            juego.AddCarta(new Cartas { Valor = 13, Palo = "Corazon" });
            juego.AddCarta(new Cartas { Valor = 14, Palo = "Trebol" });

            //Assert
            Assert.AreEqual("Escalera", juego.GetJugada().Nombre);
        }
    }
}
