using System;

namespace tri.EX13 {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Verique os lados do seu traingulo");
            System.Console.WriteLine ("Digite o primeiro numero: ");
            double num1 = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o segundo numero: ");
            double num2 = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o terceiro numero: ");
            double num3 = double.Parse (Console.ReadLine ());

            

            if ((num1 > (num2 + num3)) || (num2 > (num1 + num3)) || (num3 > (num1 + num2))) {
                System.Console.WriteLine ("Trinagulo invalido");
            } else if ((num1 < num2 + num3) && (num2 != num3) && (num1 != num2) && (num1 != num3)) {
                System.Console.WriteLine ("Tringulo equilatero");
            } else if ((num1 == num2) || (num2 == num3) || (num1 == num3)) {
                System.Console.WriteLine ("Triangulo Isosceles");
            } else if ((num1 < num2 + num3) || (num2 < num3 + num1) || (num3 < num1 + num2)) {
                System.Console.WriteLine ("Triangulo escaleno"); 
            }

        }
    }
}