using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Tucano : Animais, IGaiola
    {
        public string JogarGaiola(){
            return this.GetType().Name;
        }
    }
}