using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
        double salario = 0;
        
        Console.WriteLine("Quanto você ganha de salário?");
        salario = double.Parse(Console.ReadLine());
        

        

        if ( salario <= 500){
            Console.WriteLine("Parabans, você recebera um aumento de 30%");
        } else{
            Console.WriteLine("Que pena, você não podera recer um aumento :(");
        }

        Console.WriteLine($" Seu salario ficara :{salario * 1.3}");

        }
    }
}
