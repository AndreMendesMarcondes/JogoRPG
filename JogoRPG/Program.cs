using JogoRPG.Models;
using JogoRPG.Models.Monstros;
using System;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem meuPersonagem = new Personagem("Heimille", Personagem.ClasseJogador.Mago);
            int numeroMonstros = 0;
            Monstro meuMonstro = new Monstro();
            Combate combate = new Combate();
            var vencedor = combate.Combater(meuPersonagem, meuMonstro);
            

            while (vencedor.GetType() == typeof(Personagem))
            {
                numeroMonstros++;
                meuMonstro = new Monstro();
                 vencedor = combate.Combater(meuPersonagem, meuMonstro);
            }
            Console.WriteLine($"{meuPersonagem.Nome} matou {numeroMonstros} monstros");

            Console.ReadKey();
        }
    }
}
