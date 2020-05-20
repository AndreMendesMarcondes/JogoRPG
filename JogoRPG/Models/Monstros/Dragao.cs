namespace JogoRPG.Models.Monstros
{
    public static class Dragao
    {
        public static int Vida()
        {
            return Dado.Rolar(20);
        }
        public static int Ataque()
        {
            return Dado.Rolar(20);
        }
        public static int Defesa()
        {
            return Dado.Rolar(20);
        }
    }
}
