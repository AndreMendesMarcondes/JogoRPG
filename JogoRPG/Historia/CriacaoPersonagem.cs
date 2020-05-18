using JogoRPG.Models;
using System;
using static JogoRPG.Models.Personagem;

namespace JogoRPG.Historia
{
    public static class CriacaoPersonagem
    {
        public static void Comecar()
        {
            Escrever("Bem vindo aventureiro, vamos começar!");
            Escrever("Digite o nome do seu personagem.");
            string nomeDoPersonagem = Console.ReadLine();

            Escrever("Qual classe você deseja que seu personagem seja: ");
            Escrever("Pressione 1 para MAGO ou 2 para GUERREIRO.");
            ClasseJogador classePersonagem = (ClasseJogador)Enum.Parse(typeof(ClasseJogador),Console.ReadLine());

            Personagem personagem = new Personagem(nomeDoPersonagem, classePersonagem);
            Escrever("Seu personagem ficou pronto");
            personagem.ToString();
        }

        static void Escrever(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

