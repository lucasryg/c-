using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Pinguim : Animais, IPiscinaGelada
    {
        public string JogarPiscinaGelada(){
            return this.GetType().Name;
        }
    }
}