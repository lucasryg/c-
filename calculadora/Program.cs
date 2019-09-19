using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1° número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = (Console.ReadLine());        

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            
        }
    }
}
