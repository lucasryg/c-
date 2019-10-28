using System;

namespace imc.EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("-------IMC--------");
            System.Console.WriteLine("Quanto você pesa? ");
            float peso = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Qual é sua altura? ");
            float alt = float.Parse(Console.ReadLine());

            float alt2 = alt * alt;

            float imc = peso / alt2;    

            if (imc < 20 )
            {
                System.Console.WriteLine($"Seu IMC é: {imc}, abaixo do peso");
            }else if ((imc > 20) && (imc < 25))
            {
                System.Console.WriteLine($"Seu IMC é: {imc}, Normal");
            }else if ((imc > 25) && (imc < 30))
            {
                System.Console.WriteLine($"Seu IMC é: {imc}, Excesso de peso");
            } else if ((imc > 30 ) && (imc < 35))
            {
                System.Console.WriteLine($"Seu IMC é: {imc}, Obesidade");
            } else
            {
                System.Console.WriteLine($"Seu IMC é: {imc}, Obesidade mórbida ");
            }
        }
    }
}
