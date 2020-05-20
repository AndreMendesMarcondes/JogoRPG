using JogoRPG.Models;
using System;
using System.Threading;

namespace JogoRPG
{
    public class StatusGerais
    {
        public string Nome { get; set; }
        public int Vida { get;  set; }
        public int Ataque { get;  set; }
        public int Defesa { get;  set; }

        public int Atacar()
        {
            return Dado.Rolar(Ataque);
        }

        public int Defender(int ataqueRecebido)
        {
            int defesaAtual = Dado.Rolar(Defesa);
            Console.WriteLine($"{Nome} defendeu com {defesaAtual}");
            Thread.Sleep(2000);

            int danoRecebido = ataqueRecebido - defesaAtual;

            if (danoRecebido > 0)
            {
                Vida = Vida - danoRecebido;
            }

            if (Vida < 0)
                Vida = 0;

            return danoRecebido;
        }
        public void Apresentar()
        {
            string descricaoPersonagem = "";
            descricaoPersonagem += "Nome: " + Nome;
            descricaoPersonagem = descricaoPersonagem + "| Vida: " + Vida;
            descricaoPersonagem += "| Ataque: " + Ataque;
            descricaoPersonagem += $@"| Defesa: {Defesa}";

            Console.WriteLine(descricaoPersonagem);
        }
    }
}
