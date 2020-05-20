namespace JogoRPG.Models.Monstros
{
    public static class Troll
    {
        public static int Vida()
        {
            return Dado.Rolar(15);
        }
        public static int Ataque()
        {
            return Dado.Rolar(12);
        }
        public static int Defesa()
        {
            return Dado.Rolar(10);
        }
    }
}
