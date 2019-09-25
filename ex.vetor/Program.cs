using System;

namespace ex.vetor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] vetor = {1,2,3,4,5,6};
            int npar = 0;
            int nimpar = 0;

            Console.WriteLine("Digite um numero");
            for(int i = 0; i < 6; i++){
                Console.WriteLine("Vetor [" + i + "]");
                vetor [i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = 0; i < 6; i ++){
                
            if(vetor[i] % 2 == 0 ){
                npar++;
            }
            nimpar = 6 - npar;
            }
            Console.WriteLine("Total de numeros pares: " + npar);
            Console.WriteLine("Total de numeros impares: " + nimpar);







        }
    }
}
