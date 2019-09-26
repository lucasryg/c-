using System;

namespace temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] temperatura = new double[12];
            double maior = 0;
            double menor = 0;
            

            for(int meses= 0; meses < 12; meses++){
                Console.WriteLine($"Digite a {meses  +1} temperatura");
                temperatura[meses] = double.Parse(Console.ReadLine());
            }
            maior = temperatura[0];
            menor = temperatura[0];
            
            foreach(double temp in temperatura){
                if(temp > maior){
                    maior = temp;
                } else if (temp < menor){
                    menor = temp;
                }
            }
            Console.WriteLine($"Essa foi a maior temperatura do ano: " + maior);
            Console.WriteLine($"Essa foi a menor temperatura do ano: " + menor);
            
        }
    }
}
    

