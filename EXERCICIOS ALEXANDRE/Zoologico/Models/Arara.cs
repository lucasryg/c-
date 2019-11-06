using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Arara : Animais, IGaiola
    {
        public string JogarGaiola(){
            return this.GetType().Name + "Animal pode ir para gaiola";
        }
    }
}