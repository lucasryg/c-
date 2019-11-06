using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : TiposLixo, IIndefinido{
        public string ReciclarComo(){
            return this.GetType().Name;
        }
    }
}