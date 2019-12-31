using System;
using System.Collections.Generic;
using System.Text;

namespace Controle {
    class Movimento {

        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public TimeSpan TempoDecorrido { get; set; }

        public Movimento(DateTime entrada, DateTime saida) {
            Entrada = entrada;
            Saida = saida;
        }

        public Movimento(DateTime entrada) {
            Entrada = entrada;
        }
    }
}
