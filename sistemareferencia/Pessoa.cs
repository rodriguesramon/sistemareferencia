using System;

namespace sistemareferencia
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;
        }

        public void DizerOi()
        {
            Console.WriteLine($"Oi! Meu nome é {Nome} e eu sou {Profissao}");
        }
    }
}
