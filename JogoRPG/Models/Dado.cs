using System;

namespace JogoRPG.Models
{
    public static class Dado
    {
        public static int Jogar(int quantidadeDeLados)
        {
            Random random = new Random();
            return random.Next(1, quantidadeDeLados + 1);
        }
    }
}
