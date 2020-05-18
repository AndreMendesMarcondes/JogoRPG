using JogoRPG.Historia;
using JogoRPG.Models.Monstros;
using System;
using static JogoRPG.Models.Personagem;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Monstro meuMonstro = new Monstro(Monstro.Raca.Orc);
          
            meuMonstro.ToString();
            Console.ReadKey();            
        }

        static void Escrever(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
