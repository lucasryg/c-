using System;

namespace TERRA.EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            double mercurio = 0.37;
            double venus = 0.88;
            double marte = 0.38;
            double jupiter = 2.64;
            double saturno = 1.15;
            double urano = 1.17;

            System.Console.WriteLine("SEU PESO EM OUTROS PLANETAS");
            System.Console.WriteLine("Quanto você pesa? ");
            double pesoT = double.Parse(Console.ReadLine());

            
            System.Console.WriteLine("Escolha o planeta que voce deseja ver");
            System.Console.WriteLine("1 - Mercurio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1 :
                System.Console.WriteLine($"O seus peso na terra é de {pesoT}kg, em Mercurio é de {(pesoT/10)* mercurio}kg");
                break;
                case 2 :
                System.Console.WriteLine($"O seus peso na terra é de {pesoT}kg, em Mercurio é de {(pesoT/10)* venus}kg");
                break;
                case 3 :
                System.Console.WriteLine($"O seus peso na terra é de {pesoT}kg, em Mercurio é de {(pesoT/10)* marte}kg");
                break;
                case 4 :
                System.Console.WriteLine($"O seus peso na terra é de {pesoT}kg, em Mercurio é de {(pesoT/10)* jupiter}kg");
                break;
                case 5 :
                System.Console.WriteLine($"O seus peso na terra é de {pesoT}kg, em Mercurio é de {(pesoT/10)* saturno}kg");
                break;
                case 6 :
                System.Console.WriteLine($"O seus peso na terra é de {pesoT}kg, em Mercurio é de {(pesoT/10)* urano}kg");
                break;

            }


        }
    }
}
