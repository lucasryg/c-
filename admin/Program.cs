using System;

namespace admin1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login ;
            string senha ;
            
            
            Console.WriteLine("Login:");
            login = Console.ReadLine();

            Console.WriteLine("Senha:");
            senha = Console.ReadLine();
            
            if((login == "admin") && (senha == "admin")){
                Console.WriteLine("Bem vindo admin.");
            } else {
                Console.WriteLine("Olá usuário.");
            }
        }
    }
}
