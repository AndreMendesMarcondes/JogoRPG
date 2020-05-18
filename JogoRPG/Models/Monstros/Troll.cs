using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRPG.Models.Monstros
{
    public static class Troll
    {
        public static int Vida()
        {
            return Dado.Jogar(15);
        }
        public static int Ataque()
        {
            return Dado.Jogar(12);
        }
        public static int Defesa()
        {
            return Dado.Jogar(10);
        }
    }
}
