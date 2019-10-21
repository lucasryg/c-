using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : TiposLixo, Ilixos
    {
        public bool jogarLixo(){
            System.Console.WriteLine("Sua lixeira é da cor Amarela - Metal");
            return true;
        }
    }
}