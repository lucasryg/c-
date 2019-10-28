using System;

namespace EX20 {
    class Program {
        static void Main (string[] args) {
            int[] mtAleatorio = new int[10];
            Random numAleatorio = new Random ();

            for (int i = 0; i < 10; i++) {
                mtAleatorio[i] = numAleatorio.Next (0, 100);
            }

            for (int o = 0; o < 10; o++) {
                if ((mtAleatorio[o] % 2) == 0) {
                    System.Console.WriteLine ($"Esses numeros sao pares {mtAleatorio[o]}");
                }
            }
            for (int o = 0; o < 10; o++) {
                if ((mtAleatorio[o] % 2) == 1) {
                    System.Console.WriteLine ($"Esse numero é impare {mtAleatorio[o]}");
                }
            }

        }
    }
}