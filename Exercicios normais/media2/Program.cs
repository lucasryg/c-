using System;

namespace media2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;

            Console.WriteLine("Digite o 1° número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3° número");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4° número");
            num4 = double.Parse(Console.ReadLine());

            double media = (num1 + num2 + num3 + num4)/4;

            if (media > 9.0){
                Console.WriteLine("Parabens você passou!");
            } else if ((media >=7.0) && (media <= 9.0)){
                Console.WriteLine("iai parça passou de raspa");
            }
            else{
                Console.WriteLine("Que pena, você reprovou");
            }

            Console.WriteLine($"Sua nota é:{media}");
        }
    }
}

