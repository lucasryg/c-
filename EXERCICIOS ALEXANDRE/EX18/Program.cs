using System;

namespace EX18
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----NUMERO SUPERIO E IMPARES----");

            System.Console.WriteLine("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                if ((i % 2) == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}