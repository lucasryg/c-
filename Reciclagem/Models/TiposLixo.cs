using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    abstract class TiposLixo : Ilixos
    {

        public bool jogarLixo()
        {
            string[] trash = { "Verde", "Amarelo", "Vermelho", "Azul", "Cinza", "Preto" };
            return true;
        }
    }
}