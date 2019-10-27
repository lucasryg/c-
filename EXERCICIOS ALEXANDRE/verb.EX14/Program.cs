using System;

namespace verb.EX14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um verbo e iremos dizer se ele é infitivo, e em qual conjugação ele se encontra!");
            System.Console.WriteLine("Digite o primero verbo : ");
            string verb1 = Console.ReadLine();

           string procurar = verb1.Substring(verb1.Length - 2, 2 );

            switch (procurar)
            {
                case "ar":
                System.Console.WriteLine("Verbo da 1° Conjugação ");
                break;
                case "er":
                System.Console.WriteLine("Verbo da 2° Conjugação");
                break;
                case "ir":
                System.Console.WriteLine("Verbo da 3° Conjugação");
                break;
                default:
                System.Console.WriteLine("Seu verbo nao esta no infinitivo");
                break;
            } 

        





            
            // System.Console.WriteLine(verb1.Length);

            // int tamanhoDaPalavra = (verb1.Length);

            

            

            


            
            

        }
    }
}
