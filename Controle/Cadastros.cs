using Controle.Exececao;
using Pessoas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controle {
    class Cadastros {


        public List<Pessoa> pessoas = new List<Pessoa> { };

        public void cadastraNovaPessoa() {

            Pessoa NovaPessoa;

            Console.WriteLine("Entre com os dados abaixo: ");
            Console.WriteLine("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o CPF: ");
            string cpf = Console.ReadLine();

           // NovaPessoa = new Usuario(nome, cpf);

            Console.WriteLine("1 - Usuario\n2 - Funcionário\n3 - Prestador de Serviço\n4 - Operador");
            Console.WriteLine("Qual o tipo de cadastro: ");
            int n = int.Parse(Console.ReadLine());
            validaEscolhaCadastro(n);
            switch (n) {
                case 1:
                    NovaPessoa = new Usuario(nome, cpf);
                    pessoas.Add(NovaPessoa);
                    Console.WriteLine($"Cadastro Realizado com Sucesso! #ID: {NovaPessoa.Identificação} foi salvo!");
                    break;
                case 2:
                    //NovaPessoa = new Funcionario(nome, cpf);
                    //pessoas.Add(NovaPessoa);
                    //Console.WriteLine($"Cadastro Realizado com Sucesso! #ID: {NovaPessoa.Identificação} foi salvo!");
                    break;
                case 3:
                    //NovaPessoa = new PrestadorDeServico(nome, cpf);
                    //pessoas.Add(NovaPessoa);
                    //Console.WriteLine($"Cadastro Realizado com Sucesso! #ID: {NovaPessoa.Identificação} foi salvo!");
                    break;
                case 4:
                    //NovaPessoa = new Operador(nome, cpf);
                    //pessoas.Add(NovaPessoa);
                    //Console.WriteLine($"Cadastro Realizado com Sucesso! #ID: {NovaPessoa.Identificação} foi salvo!");
                    break;
            }
        }

        public void validaEscolhaCadastro(int n) {
            if(n < 0 || n > 4) {
                throw new ControleException("Escolha Inválida!");
            }
        }

    }
}
