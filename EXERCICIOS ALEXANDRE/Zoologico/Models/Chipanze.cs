using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Chipanze : Animais, ICasaEmArvore
    {
        public string JogarCasaArvore(){
            return this.GetType().Name + "Pode ir para casa da arvore";
        }
    }
}