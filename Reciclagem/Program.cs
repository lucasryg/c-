using System;
using System.Collections.Generic;
using Reciclagem.interfaces;
using Reciclagem.Models;

namespace Reciclagem {

    enum Lixosos : int {
        Garrafa = 1,
        GarrafaPET,
        Latinha,
        GuardaChuva,
        Papelao,
        PoteManteiga,

    }
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
        public static bool ColocarNoLixo () {
            int codigo;
            int codigo = int.Parse (Console.ReadLine());

            var Lixos;
        }

    }
}