using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoas {
    class Usuario : Pessoa {

        public Usuario(string nome, string cpf) : base(nome, cpf) {
            nivel = Nivel.Usuario;
        }

        public override string ToString() {
            return "#Id: " + Identificação + ", Nome: " + Nome
                + ", CPF: " + Cpf
                + ", Nivel de Acesso: " + nivel;
        }
    }
}
