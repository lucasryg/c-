using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Orangotango : Animais, ICasaEmArvore
    {
        public string JogarCasaArvore(){
            return this.GetType().Name + "Jogar na casa da arvore";
        }
    }
}