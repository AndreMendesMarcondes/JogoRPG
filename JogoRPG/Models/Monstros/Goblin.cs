namespace JogoRPG.Models.Monstros
{
    public static class Globlin
    {
        public static int Vida()
        {
            return Dado.Rolar(15);
        }
        public static int Ataque()
        {
            return Dado.Rolar(8);
        }
        public static int Defesa()
        {
            return Dado.Rolar(10);
        }
    }
}
