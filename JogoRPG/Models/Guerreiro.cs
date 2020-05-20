namespace JogoRPG.Models
{
    public static class Guerreiro
    {
        public static int Vida()
        {
            return RolarDadoGuerreiro(20);
        }
        public static int Ataque()
        {
            return RolarDadoGuerreiro(15);
        }
        public static int Defesa()
        {
            return RolarDadoGuerreiro(15);
        }

        private static int RolarDadoGuerreiro(int numeroDeLadosDado)
        {
            int valorDoDadoJogado = Dado.Rolar(numeroDeLadosDado);

            if (valorDoDadoJogado * 100 / numeroDeLadosDado > 70)
            {
                return valorDoDadoJogado;
            }

            return RolarDadoGuerreiro(numeroDeLadosDado);
        }
    }
}
