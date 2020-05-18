using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRPG.Models.Monstros
{
    public class Monstro
    {
        private string NomeRaca { get; set; }
        public enum Raca { Orc = 1, Slime = 2 };
        public int Vida { get; private set; }
        public int Ataque { get; private set; }
        public int Defesa { get; private set; }

        public Monstro(Raca racaMonstro)
        {
            NomeRaca = racaMonstro.ToString();
            switch (racaMonstro)
            {
                case Raca.Orc:
                    MontarDadosOrc();
                    break;
                case Raca.Slime:
                    MontarDadosSlime();
                    break;
                default:
                    break;
            }
        }

        private void MontarDadosSlime()
        {
            Ataque = Slime.Vida();
            Defesa = Slime.Defesa();
            Vida = Slime.Vida();
        }

        private void MontarDadosOrc()
        {
            Vida = Orc.Vida();
            Defesa = Orc.Defesa();
            Ataque = Orc.Ataque();
        }

        public override string ToString()
        {
            string descricaoMonstro = "";
            descricaoMonstro = descricaoMonstro + "| Raça: " + NomeRaca;
            descricaoMonstro = descricaoMonstro + "| Vida: " + Vida;
            descricaoMonstro += "| Ataque: " + Ataque;
            descricaoMonstro += $@"| Defesa: {Defesa}";

            Console.WriteLine(descricaoMonstro);

            return descricaoMonstro;
        }
    }
}
