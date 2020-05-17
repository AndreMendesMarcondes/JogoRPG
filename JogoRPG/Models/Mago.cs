namespace JogoRPG.Models
{
    public static class Mago
    {
        public static int Vida()
        {
            return RolarDadoMago(10);
        }
        public static int Ataque()
        {
            return RolarDadoMago(30);
        }
        public static int Defesa()
        {
            return RolarDadoMago(10);
        }

        private static int RolarDadoMago(int numeroDeLadosDado)
        {
            int valorDoDadoJogado = Dado.Jogar(numeroDeLadosDado);

            if (valorDoDadoJogado * 100 / numeroDeLadosDado > 70)
            {
                return valorDoDadoJogado;
            }

            return RolarDadoMago(numeroDeLadosDado);
        }
    }
}
