using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : TiposLixo, IVidro
    {
        public string ReciclarTipoVidro (){
            return this.GetType().Name;
        }
    }
}