using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 0;
            float h = 0;    
            float l = 0;
            float r = 0;
            float b = 0;
            float B = 0;

            Console.WriteLine("Digite o numero da forma que voce deseja saber a área");
            Console.WriteLine("1 - quadrado");
            Console.WriteLine("2 - triangulo");
            Console.WriteLine("3 - circulo");
            Console.WriteLine("4 - trapézio");
            Console.WriteLine("5 - retangulo");
            Console.WriteLine("6 - losango");
            num = int.Parse(Console.ReadLine());
            

            
            switch(num) {
                    case 1:
                    Console.WriteLine("Digite quantos metros de altura tem sua figura:");
                    h = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quantos metros de largura tem sua figura:");
                    l = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu quadrado tem {h} metros de altura, {l} metros de largura, e sua área mede: {h*l} metros quadrados!");
                    break;

                    case 2:
                    Console.WriteLine("Digite quantos metros de altura tem sua figura:");
                    h = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quantos metros de largura tem sua figura:");
                    l = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu triangulo tem {h} metros de altura, {l} metros de largura, e sua área mede: {(h*l)/2} metros quadrados!");
                    break;

                    case 3:
                    Console.WriteLine("Digite quantos metros tem o raio de seu circulo:");
                    r = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu circulo tem: {3.14 * (r*r)} metros quadrados!");
                    break;

                    case 4:
                    Console.WriteLine("Digite quantos metros de altura tem sua figura:");
                    h = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quantos metros de base menor tem sua figura:");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quantos metros de base maior tem sua figura:");
                    B = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu trapézio tem {h} metros de altura, {b} metros de base menor, {B} metros de base maior, e sua área mede: {((b+B)*h)/2} metros quadrados!");
                    break;

                    case 5:
                    Console.WriteLine("Digite quantos metros de altura tem sua figura:");
                    h = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quantos metros de largura tem sua figura:");
                    l = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu retangulo tem {h} metros de altura, {l} metros de largura, e sua área mede: {h*l} metros quadrados!");
                    break;

                    case 6:
                    Console.WriteLine("Digite quantos metros de altura tem sua figura:");
                    h = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quantos metros de largura tem sua figura:");
                    l = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Seu quadrado tem {h} metros de altura, {l} metros de largura, e sua área mede: {(h*l)/2} metros quadrados!");
                    break;
                    -
                }
    }
}