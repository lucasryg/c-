using System;

namespace triangulo.EX8 {
    class Program {
        static void Main (string[] args) {
            
                System.Console.WriteLine ("Digite a altura do seu triangulo: ");
                int alt = int.Parse (Console.ReadLine ());
            
                string ast2 = "*";
                

                int i = 0;

                while( alt != 0 ){

                for(i = alt; i != 0; i--){ 
                    Console.Write(ast2);
                }
                alt --;
                System.Console.WriteLine("");
                }
        }
    }
}