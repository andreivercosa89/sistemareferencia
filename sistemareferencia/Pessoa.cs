using System;
namespace sistemareferencia
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }

        public void Dados(){

            Console.WriteLine("Nome: {0}\nIdade:{1}\nEndereco: {2}", Nome, Idade, Endereco);
        }

        public Pessoa (string Enderco){
            this.Endereco = Enderco;
        }


        public Pessoa()
        {

        }
    }
}
