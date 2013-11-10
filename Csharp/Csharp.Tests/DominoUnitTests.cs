﻿using System;
using System.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp.Tests
{
    //Este proyecto usa MsTest para los unit tests. Más información aqui:
    //http://msdn.microsoft.com/en-us/library/ms182532.aspx

    //MsTest es el framework de Testing que viene predeterminado en Visual Studio, 
    //si quieres una alternativa también puedes ver nUnit: http://www.nunit.org/

    [TestClass]
    public class DominoUnitTests
    {
        [TestMethod]
        public void DebePoderComenzarUnJuego()
        {
            var juego = new JuegoDomino();
            juego.JugarFicha(Jugadores.Primero, new Ficha(6, 6));

            Assert.IsNotNull(juego);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ElJuegoDebeComenzarConUnDoble()
        {
            var juego = new JuegoDomino();
            juego.JugarFicha(Jugadores.Primero, new Ficha(3, 4));

            Assert.IsNull(juego.Fichas);
        }

        [TestMethod]
        public void SePuedeJugarUnaFichaNueva()
        {
            var juego = new JuegoDomino();
            juego.JugarFicha(Jugadores.Primero, new Ficha(6,6)); //Primera
            juego.JugarFicha(Jugadores.Segundo, new Ficha(6,0)); //Segunda

            Assert.IsTrue(juego.Fichas.Anterior != null || juego.Fichas.Siguiente != null);
        }

        [TestMethod]
        public void SoloSePuedeJugarUnNumeroComunEnTablero()
        {
            var juego = new JuegoDomino();
            juego.JugarFicha(Jugadores.Primero, new Ficha(5,5));
            juego.JugarFicha(Jugadores.Segundo, new Ficha(4,3));

            Assert.IsNull(juego.Fichas.Siguiente);
            Assert.IsNull(juego.Fichas.Anterior);
        }

    }
}
