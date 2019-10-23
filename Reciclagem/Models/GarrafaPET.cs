using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models {
    public class GarrafaPET : TiposLixo, IPlastico {
        public string ReciclarTipoPlastico () {
            return this.GetType().Name;
        }
    }
}