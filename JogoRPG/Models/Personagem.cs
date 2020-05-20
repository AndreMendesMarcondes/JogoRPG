using System;

namespace JogoRPG.Models
{
    public class Personagem : StatusGerais
    {
        public enum ClasseJogador { Mago = 1, Guerreiro = 2 };

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
    }
}
