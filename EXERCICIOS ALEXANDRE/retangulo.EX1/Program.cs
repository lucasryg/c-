using System;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor da base do seu retângulo");
            double b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura do seu retângulo");
            double h = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"{b * h} esse é a area do seu retângulo ");
            System.Console.WriteLine($"{2*(b+h)} esse é o perimetro do seu retângulo");
            System.Console.WriteLine($"A diagonal do seu retangulo: {Math.Sqrt(b * b) + (h * h)}");

        }
    }
}
