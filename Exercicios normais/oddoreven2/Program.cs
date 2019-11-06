using System;

namespace oddoreven2
{
    class Program
    {

        static void Main(string[] args)
        {
           int num = 0;

            do{
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());

                if(( num % 2) != 0){
                    Console.WriteLine("Seu número é par");
                } else{
                    Console.WriteLine("Seu número é impar");
                }
            } while( num != 0);
        }
    }
}
    

