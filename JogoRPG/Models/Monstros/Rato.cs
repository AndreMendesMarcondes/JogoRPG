namespace JogoRPG.Models.Monstros
{
    public static class Rato
    {
        public static int Vida()
        {
            return Dado.Rolar(5);
        }
        public static int Ataque()
        {
            return Dado.Rolar(5);
        }
        public static int Defesa()
        {
            return Dado.Rolar(5);
        }
    }
}
