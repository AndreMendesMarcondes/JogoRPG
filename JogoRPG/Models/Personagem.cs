using System;
using System.Security.Cryptography;

namespace JogoRPG.Models
{
    public class Personagem
    {
        public enum ClasseJogador { Mago = 1, Guerreiro = 2 };
        public string Nome { get; private set; }
        public int Vida { get; private set; }
        public int Ataque { get; private set; }
        public int Defesa { get; private set; }

        public Personagem(string nomeConstrutor, ClasseJogador classeDoJogador)
        {
            Nome = nomeConstrutor;

            switch (classeDoJogador)
            {
                case ClasseJogador.Mago:
                    MontarDadosDoMago();
                    break;
                case ClasseJogador.Guerreiro:
                    MontarDadosGuerreiro();
                    break;
                default:
                    break;
            }
        }

        private void MontarDadosGuerreiro()
        {
            Vida = Guerreiro.Vida();
            Ataque = Guerreiro.Ataque();
            Defesa = Guerreiro.Defesa();
        }

        private void MontarDadosDoMago()
        {
            Vida = Mago.Vida();
            Ataque = Mago.Ataque();
            Defesa = Mago.Defesa();
        }

        public override string ToString()
        {            
            string descricaoPersonagem = "";
            descricaoPersonagem += "Nome: " + Nome;
            descricaoPersonagem = descricaoPersonagem +  "| Vida: " + Vida;
            descricaoPersonagem += "| Ataque: " + Ataque;
            descricaoPersonagem += $@"| Defesa: {Defesa}";

            Console.WriteLine(descricaoPersonagem);

            return descricaoPersonagem;
        }

        public int Atacar()
        {
            return Dado.Jogar(Ataque);
        }

        public void Defender(int ataqueRecebido)
        {
            int defesaAtual = Dado.Jogar(Defesa);
            int danoRecebido = ataqueRecebido - defesaAtual;

            if (danoRecebido > 0)
            {
                Vida = danoRecebido;
            }

            if(Vida < 0)
            {
                Console.WriteLine("Você morreu my friend.");
            } else if (Vida == 0)
            {
                Console.WriteLine("Você desmaiou.");
            }
        }
    }
}
