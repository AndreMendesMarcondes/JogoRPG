﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRPG.Models.Monstros
{
    public class Monstro
    {
        private string NomeRaca { get; set; }
        public enum Raca { Orc = 1, Slime = 2, Goblin = 3, Troll = 4, Rato = 5, Dragao = 6 };
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
                case Raca.Goblin:
                    MontarDadoGloblin();
                    break;
                case Raca.Troll:
                    MontarDadoTroll();
                    break;
                case Raca.Rato:
                    MontarDadoRato();
                    break;
                case Raca.Dragao:
                    MontarDadoDragao();
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

        private void MontarDadoGloblin()
        {
            Vida = Globlin.Vida();
            Defesa = Globlin.Defesa();
            Ataque = Globlin.Ataque();
        }

        private void MontarDadoTroll()
        {
            Vida = Troll.Vida();
            Defesa = Troll.Defesa();
            Ataque = Troll.Ataque();
        }

        private void MontarDadoRato()
        {
            Vida = Rato.Vida();
            Defesa = Rato.Defesa();
            Ataque = Rato.Ataque();
        }

        private void MontarDadoDragao()
        {
            Vida = Dragao.Vida();
            Defesa = Dragao.Defesa();
            Ataque = Dragao.Ataque();
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
