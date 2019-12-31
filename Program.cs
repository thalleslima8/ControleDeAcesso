using Pessoas;
using System;

namespace ControleDeAcesso {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("                                 SCA");

            Pessoa NovaPessoa;

            Console.WriteLine("Entre com os dados de Acesso: ");
            Console.WriteLine("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o CPF: ");
            string cpf = Console.ReadLine();

            NovaPessoa = new Usuario(nome, cpf);

            Console.WriteLine(NovaPessoa);
        }
    }
}
