using System;

namespace alfa.EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o primero nome");
            string nome1 = Console.ReadLine();

            System.Console.WriteLine("Digite o segundo nome");
            string nome2 = Console.ReadLine();

            int comp = string.Compare(nome1,nome2);

            if (comp == 1)
            {
                Console.Clear();
                
                System.Console.WriteLine(nome2);
                System.Console.WriteLine(nome1);
            }else if(comp == 0)
            {
                Console.Clear();
                
                System.Console.WriteLine(nome1);
            }else{
                Console.Clear();
                
                System.Console.WriteLine(nome1);
                System.Console.WriteLine(nome2);
            }

            
            
        }
    }
}
