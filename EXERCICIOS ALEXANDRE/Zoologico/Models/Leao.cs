using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Leao : Animais, IPasto
    {
        public string JogarPasto(){
            return this.GetType().Name + "Pode ir para o Pasto";
        }
    }
}