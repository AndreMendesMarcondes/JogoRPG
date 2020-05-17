using JogoRPG.Historia;
using System;
using static JogoRPG.Models.Personagem;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            CriacaoPersonagem.Comecar();

            Console.ReadKey();            
        }

        static void Escrever(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
