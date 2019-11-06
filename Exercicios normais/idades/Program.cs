using System;

namespace idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;

            do{
            Console.WriteLine("Digite o ano do seu nascimento");
            ano = int.Parse(Console.ReadLine());
            if(ano > 2021){
                Console.WriteLine("Data inváida");
            }
            } while((ano >2021) || (ano < 1900));

            int idade = (2019 - ano);

            Console.WriteLine("Voce tem:" + idade);
            
            
            if(idade <= 2){
                Console.WriteLine("Recém-Nascido");
            } else if((idade >= 3) && (idade <= 11)){
                Console.WriteLine("Criança");
            } else if((idade >= 12) && (idade <= 19)){
                Console.WriteLine("Adolescente");
            } else if ((idade >= 20)&&(idade <= 65)){
                Console.WriteLine("Adulto");
            } else{
                Console.WriteLine("Idoso");
            }
        }
    }
}

