using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : TiposLixo, IMetal
    {
        public string ReciclarTipoMetal(){
            return this.GetType().Name;
        }
    }
}