using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {10, 15, 48},
                {52, 97, 77},
                {2, 100, 33}
            };

            int soma = 0;
            foreach (var item in matrix)
            {
                soma += item;
            }
            System.Console.WriteLine(soma);
    }
}
}

