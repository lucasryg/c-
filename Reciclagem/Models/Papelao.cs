using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : TiposLixo, IPapel
    {
        public string ReciclarTipoPapel(){
            return this.GetType().Name;
        }
    }
}