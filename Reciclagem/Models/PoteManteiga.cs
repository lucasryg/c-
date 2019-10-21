using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PoteManteiga : TiposLixo, Ilixos
    {
        public bool jogarLixo () {
            System.Console.WriteLine ("O lixo devera ser mandado para a composteira");
            return true;
        }
    }
}