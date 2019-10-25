using System;

namespace nume.EX12 {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Digite o primeiro numero: ");
            double num1 = double.Parse (Console.ReadLine ());

            System.Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o terceiro numero: ");
            double num3 = double.Parse(Console.ReadLine());

            double aux = 0;

        if (num1 > num2)
        {
            aux = num1;
            num1 = num2;
            num2 = aux;
        }
        if (num1 > num3)
        {
            aux = num1;
            num1 = num3;
            num3 = aux;
        }
        if (num2 > num3)
        {
            aux = num2;
            num2 = num3;
            num3 = aux;
        }

        System.Console.WriteLine($"{num1},{num2},{num3}");
        }
    }
}