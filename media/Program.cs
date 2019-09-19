using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;
            

            Console.WriteLine("Digite a 1° nota");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2° nota");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3° nota");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 4° nota");
            num4 = float.Parse(Console.ReadLine());

            float numtotal = (num1 + num2 + num3 + num4) ;

            Console.WriteLine($"Sua média é:{numtotal/4}");
        }
    }
}
