using Interface;
using Pessoas;
using System;

namespace ControleDeAcesso {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("                                 SCA");
            Menu m = new Menu();
            m.MostraMenu();
            m.chamaTarefa();
            
        }
    }
}
