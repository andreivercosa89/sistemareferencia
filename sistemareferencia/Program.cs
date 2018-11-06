using System;

namespace sistemareferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Rua 7 de Setembro");

            Console.WriteLine("Informe o Nome: ");
            pessoa.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("\nInforme a Idade: ");
            pessoa.Idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o Endereco: ");
            pessoa.Endereco = Console.ReadLine();

            Console.Clear();
            pessoa.Dados();
        }
    }
}
