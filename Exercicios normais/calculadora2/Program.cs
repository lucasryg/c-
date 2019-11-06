using System;

namespace calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1° número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            oper = Console.ReadLine();
            Console.WriteLine("Digire o 2° número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Este é seu resultado: ");
        
            switch (oper){
                case "+":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;

                case "-":
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;

                case "*":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

                case "/":
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;

                case "%":
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;

                default:
                Console.WriteLine("Operação invalida!");
                break;
            }

                // if(oper == "+"){
                // Console.WriteLine($"{num1} + {num2} {num1 + num2}");
                // } else if(oper == "-"){
                // Console.WriteLine($"{num1} - {num2} {num1 - num2}");
                // } else if(oper == "*"){
                // Console.WriteLine($"{num1} * {num2} {num1 * num2}");
                // else if(oper == "/"){
                // Console.WriteLine($"{num1} / {num2} {num1 / num2}");
                // } else if(oper == "%"){
                // Console.WriteLine($"{num1} % {num2} {num1 % num2}");
                // } else{
                //     Console.WriteLine("Operação invalida");
                // }
                
        }
    }
}
