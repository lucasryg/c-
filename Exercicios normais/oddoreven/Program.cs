using System;

namespace oddoreven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            Console.WriteLine("Digite um número");
            Console.ReadLine();

            if( num1 % 2 == 0){
                Console.WriteLine("Seu número é par");
            } else{
                Console.WriteLine("Seu número é impar");
            }
            
        }
    }
}
