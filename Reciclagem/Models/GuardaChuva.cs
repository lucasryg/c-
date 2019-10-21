using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : TiposLixo, Ilixos
    {
        public bool jogarLixo(){
            System.Console.WriteLine("Sua lixeira é da cor Cinza - Indefinido");
            return true;
        }
    }
}