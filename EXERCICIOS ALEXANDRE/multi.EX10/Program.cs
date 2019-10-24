using System;

namespace multi.EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());

            if ((num / 3) == 0)
            {
                System.Console.WriteLine("Seu número nao é multiplo de 3");
            } else
            {
                System.Console.WriteLine("Seu número é multiplo de 3");
            }
        }
    }
}
