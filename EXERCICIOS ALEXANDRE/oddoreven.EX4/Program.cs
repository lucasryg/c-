using System;

namespace dororeven
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero que voce deseja saber se é impar ou par: ");
            double oe = double.Parse(Console.ReadLine());

            if ((oe % 2) == 0)
            {
                System.Console.WriteLine("Seu número é par");
            } else
            {
                System.Console.WriteLine("seu número é impar");
            }

        }
    }
}
