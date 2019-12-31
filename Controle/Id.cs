using Controle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controle {
    class Id {

        private int NumeroDeIdentificacao = 1000;
        

        public Id() {

        }

        public int novoNumeroDeIdentificacao() {
            incrementaId();
            return NumeroDeIdentificacao;
        }

        public void incrementaId() {
            NumeroDeIdentificacao++;
        }

        public void decrementaId() {
            NumeroDeIdentificacao--;
        }

    }
}
