using JogoRPG.Models;
using System;
using System.Threading;

namespace JogoRPG
{
    public class Combate
    {
        private enum Combatentes { Personagem, Monstro };

        public StatusGerais Combater(StatusGerais personagem, StatusGerais monstro)
        {
            personagem.Apresentar();
            Esperar();
            monstro.Apresentar();
            Esperar();

            StatusGerais player1 = new StatusGerais();
            StatusGerais player2 = new StatusGerais();
            StatusGerais playerAux = new StatusGerais();

            Console.WriteLine("----------------------------- É HORA DO DUELO -----------------------------");
            var playerQueComeca = QuemComeca();

            switch (playerQueComeca)
            {
                case Combatentes.Personagem:
                    player1 = personagem;
                    player2 = monstro;
                    break;
                case Combatentes.Monstro:
                    player1 = monstro;
                    player2 = personagem;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Quem começa atacando é o {player1.Nome}");
            Esperar();

            bool combateContinua = true;

            while (combateContinua == true)
            {
                combateContinua = Atacar(player1, player2);

                if (combateContinua == true)
                {
                    playerAux = player1;
                    player1 = player2;
                    player2 = playerAux;
                }
            }

            Console.WriteLine($"{player1.Nome} venceu!");
            return player1;
        }

        private Combatentes QuemComeca()
        {
            int valorDadoPersonagem = Dado.Rolar(10);
            int valorDadoMonstro = Dado.Rolar(10);

            if (valorDadoPersonagem >= valorDadoMonstro)
                return Combatentes.Personagem;

            return Combatentes.Monstro;
        }


        private bool Atacar(StatusGerais atacante, StatusGerais defensor)
        {
            int valorAtaque = atacante.Atacar();
            Console.WriteLine($"{atacante.Nome} ataca com {valorAtaque}");
            Esperar();

            int defesa = defensor.Defender(valorAtaque);
            if (defesa > 0)
            {
                Console.WriteLine($"{defensor.Nome} tomou {defesa} de dano e agora está com {defensor.Vida} de vida");
                Esperar();
            }
            else
            {
                Console.WriteLine($"{defensor.Nome} defendeu!");
                Esperar();
            }

            if (defensor.Vida <= 0)
            {
                Console.WriteLine($"{defensor.Nome} morreu");
                Esperar();
                return false;
            }

            return true;
        }

        private void Esperar() => Thread.Sleep(2000);
    }
}

