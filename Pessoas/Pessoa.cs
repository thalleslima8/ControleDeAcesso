using Controle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoas {
    abstract class Pessoa {

        public int Identificação { get; set; }
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public bool Acesso { get; private set; }
        public Movimento Entrada;
        protected Nivel nivel;

        public Pessoa(string nome, string cpf) {
            Identificação = new Id().novoNumeroDeIdentificacao();
            Nome = nome;
            Cpf = cpf;
            Acesso = false;

        }

        public void alteraAcesso() {
            if (Acesso) {
                Acesso = false;
            } else {
                Acesso = true;
            }
        }

        public override string ToString() {
            return "Nome: " + Nome
                + ", CPF: " + Cpf;
        }
    }
}
