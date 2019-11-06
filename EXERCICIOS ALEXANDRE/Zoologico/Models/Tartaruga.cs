using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Tartaruga : Animais, IPiscina
    {
        public string JogarPiscina(){
            return this.GetType().Name;
        }
    }
}