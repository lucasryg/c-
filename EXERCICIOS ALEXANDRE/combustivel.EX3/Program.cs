using System;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--------Verificador-de-Combustivel--------");
            System.Console.WriteLine("Quanto tempo você demorou para fazer todo o percurso? ");
            double tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual foi a média da velocidade de sua viagem? ");
            double velocidade = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"A Distancia q voce percorreu é de: {tempo * velocidade} km");
            double distancia = tempo * velocidade;

            System.Console.WriteLine($"Você usou {distancia / 12} litros de combustível");
        }
    }
}
