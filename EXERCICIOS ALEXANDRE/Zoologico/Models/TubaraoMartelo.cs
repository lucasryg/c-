using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class TubaraoMartelo : Animais, IAquario
    {
        public string JogarNoAquario(){
            return this.GetType().Name;
        }
    }
}