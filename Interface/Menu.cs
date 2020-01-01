using Controle;
using Controle.Exececao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class Menu {

        public int N { get; set; }

        public Menu() {
        }

        public void MostraMenu() {
            Console.Clear();
            ConsoleColor aux = Console.BackgroundColor;
            Console.Write("                                         ");
            Console.BackgroundColor = ConsoleColor.Green;
            ConsoleColor aux1 = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Sistema Controle de Acesso\n\n");
            Console.BackgroundColor = aux;
            Console.ForegroundColor = aux1;
            Console.WriteLine("0 - Sair\n1 - Cadastro de Novo Usuário\n2 - Mostrar Usuários Cadastrados");
            
        }

        public bool validarEscolha(int n) {
            if(n < 0 || n > 2) {
                return false;
            }
            return true;
        }

        public void escolhaValida(int n) {
            if (!validarEscolha(n)) {
                throw new ControleException("Escolha Inválida!");
            }
        }

        public void chamaTarefa() {
            int n = int.Parse(Console.ReadLine());
            escolhaValida(n);
            Cadastros c = new Cadastros();
            switch (n) {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    c.cadastraNovaPessoa();
                    break;
            }
        }

    }
}
