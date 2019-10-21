using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models {
    public class GarrafaPET : TiposLixo, Ilixos {
        public bool jogarLixo () {
            System.Console.WriteLine ("Sua lixeira é o da cor Vemelha - Plástico");
            return true;
        }
    }
}