﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRPG.Models.Monstros
{
    public static class Rato
    {
        public static int Vida()
        {
            return Dado.Jogar(5);
        }
        public static int Ataque()
        {
            return Dado.Jogar(5);
        }
        public static int Defesa()
        {
            return Dado.Jogar(5);
        }
    }
}
