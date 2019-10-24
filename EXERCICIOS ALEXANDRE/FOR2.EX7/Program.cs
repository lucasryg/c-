using System;

namespace FOR2.EX7 {
    class Program {
        static void Main (string[] args) {
            for (int i = 1; i < 10; i = i + 2) {
                System.Console.WriteLine (i);
            }


            //! meu 
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 1) {
                    System.Console.WriteLine (i);
                }
            }
        }
    }
}