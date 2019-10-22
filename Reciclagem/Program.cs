using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem {

    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("------Auxiliar de reciclagem------");
            System.Console.WriteLine ("Qual desses lixos voce deseja jogar fora?");
            System.Console.WriteLine ("1 - Garrafa");
            System.Console.WriteLine ("2 - GarrafaPET");
            System.Console.WriteLine ("3 - GuardaChuva");
            System.Console.WriteLine ("4 - Latinha");
            System.Console.WriteLine ("5 - Papelao");
            System.Console.WriteLine ("6 - PoteManteiga");

            ColocarNoLixo ();

        }
        public static void ColocarNoLixo () {
            int opcao = int.Parse(Console.ReadLine());
            var Lixos = Deposito.Lixos[opcao];
            Ilixos.jogarLixo();
        }

    }
}