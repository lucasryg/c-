using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : TiposLixo, Ilixos
    {
        public bool jogarLixo (){
            System.Console.WriteLine("Sua lixeira é o da cor Verde - Vidro");
            return true;
        }
    }
}