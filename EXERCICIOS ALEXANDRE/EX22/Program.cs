using System;

namespace EX22   
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] vet3 = new int[3,3];
            Random numAleatorio = new Random ();

            for (int i = 0; i < 9; i++)
            {
                vet3[i,i] = numAleatorio.Next(0,100);
            }




        }
    }
}
