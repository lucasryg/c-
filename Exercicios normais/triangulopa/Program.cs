using System;

namespace triangulopa501
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;
            int qnt = 0;

            Console.WriteLine("Quantos triangulos você quer?");
            qnt = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a altura que você deseja?");
            altura = int.Parse(Console.ReadLine());

            for(int triangulos = 0; qnt <= 0; triangulos++){
                // Console.WriteLine(altura * "*");
            }
        }
    }
}
