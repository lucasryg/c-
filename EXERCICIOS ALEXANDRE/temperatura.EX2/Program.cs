using System;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Digite a temperatura: ");
            int tempo = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"{(9*tempo + 160)/5} Fahrenheit"  );
        }
    }
}
