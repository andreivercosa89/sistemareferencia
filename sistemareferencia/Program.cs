using System;

namespace sistemareferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Rua 7 de Setembro");
            //Pessoa pessoa02 = pessoa;
            Pessoa pessoa02 = new Pessoa ();
            pessoa02.Idade = pessoa.Idade;
            pessoa02.Endereco  = pessoa.Endereco;


            Console.WriteLine("Informe o Nome: ");
            pessoa.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("\nInforme a Idade: ");
            pessoa.Idade = Int32.Parse(Console.ReadLine());

            Console.Clear();
            pessoa02.Nome = "Maria";

            pessoa.Dados();

            pessoa02.Dados();
        }
    }
}
