using System;

namespace EX19
{
    class Program
    {
        static void Main(string[] args)     
        {
            System.Console.WriteLine("----VETOR----");
            System.Console.WriteLine("Quantas ocorrencias você quer?"); 
            int qntOcorrencia = int.Parse(Console.ReadLine());

            int[] vetor = new int[qntOcorrencia];
            
            for (int i = 0; i < qntOcorrencia; i++)
            {  
                System.Console.WriteLine($"Digite o {i} item: ");
                vetor[i] = int.Parse(Console.ReadLine());
            } 
        }
    }
}
