using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : TiposLixo, Ilixos
    {
        public bool jogarLixo(){
            System.Console.WriteLine("Sua lixeria é da cor Azul - Papel");
            return true;
        }
    }
}