using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Golfinho : Animais, IAquario
    {
        public string JogarNoAquario(){
            return this.GetType().Name + "Pode ir para o aquario";
        }
    }
}