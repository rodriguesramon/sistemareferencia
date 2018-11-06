using System;

namespace sistemareferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Ramon", "Developer");
            pessoa.DizerOi();

            Pessoa pessoa2 = pessoa;

            pessoa2.Nome = "Maria";
            pessoa2.Profissao = "Atriz";

            pessoa.DizerOi();
            pessoa2.DizerOi();

            Console.ReadKey();
        }
    }
}
