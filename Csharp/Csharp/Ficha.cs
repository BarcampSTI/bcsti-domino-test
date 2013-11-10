﻿using System.Collections;

namespace Csharp
{
    /// <summary>
    /// Representa una ficha en un juego de domino
    /// </summary>
    public class Ficha
    {
        public struct ValorFicha
        {
            public int A;
            public int B;

            public ValorFicha(int a, int b)
            {
                A = a;
                B = b;
            }
        }

        public ValorFicha Valor { get; set; }
        public Ficha Siguiente { get; set; }
        public Ficha Anterior { get; set; }

        public Ficha(int a, int b)
        {
            Valor = new ValorFicha(a, b);
        }
    }
}
