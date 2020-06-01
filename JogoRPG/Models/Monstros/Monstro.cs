using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoRPG.Models.Monstros
{
    public class Monstro : StatusGerais
    {
        public enum Raca { Orc = 1, Slime = 2, Goblin = 3, Troll = 4, Rato = 5, Dragao = 6};

        private Raca RacaMonstro;

        public Raca SortearMonstro()
        {
            List<int> listaDePesos = new List<int>();
            listaDePesos.Add(40);//orc
            listaDePesos.Add(50);//slime
            listaDePesos.Add(60);//goblin
            listaDePesos.Add(30);//troll
            listaDePesos.Add(50);//rato
            listaDePesos.Add(20);//dragao

            int somaTotalDePesos = listaDePesos.Sum();

            List<int> listaAparecimentoMonstros = new List<int>();
            int enumDoMonstro = 1;

            foreach (var monstro in listaDePesos)
            {
                for (int i = 0; i < monstro; i++)
                {
                    listaAparecimentoMonstros.Add(enumDoMonstro);                    
                }
                enumDoMonstro++;
            }

            Random random = new Random();
            int numeroDoMonstroSorteado = random.Next(0, somaTotalDePesos);
            return (Raca)listaAparecimentoMonstros[numeroDoMonstroSorteado];
        }

        public Monstro()
        {
            RacaMonstro = SortearMonstro();
            Nome = RacaMonstro.ToString();
            switch (RacaMonstro)
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
                    Console.WriteLine("AGORA FUDEU!");
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
    }
}

