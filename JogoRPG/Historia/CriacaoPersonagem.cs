using JogoRPG.Models;
using System;
using static JogoRPG.Models.Personagem;

namespace JogoRPG.Historia
{
    public static class CriacaoPersonagem
    {
        public static void Comecar()
        {

            Console.WriteLine("Bem vindo aventureiro, vamos começar!");
            Console.WriteLine("Digite o nome do seu personagem.");
            string nomeDoPersonagem = Console.ReadLine();

            Console.WriteLine("Qual classe você deseja que seu personagem seja: ");
            Console.WriteLine("Pressione 1 para MAGO ou 2 para GUERREIRO.");
            ClasseJogador classePersonagem = (ClasseJogador)Enum.Parse(typeof(ClasseJogador), Console.ReadLine());

            Personagem personagem = new Personagem(nomeDoPersonagem, classePersonagem);
            Console.WriteLine("Seu personagem ficou pronto");
            personagem.ToString();
        }
    }
}

