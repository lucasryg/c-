using System.Collections.Generic;

namespace Zoologico.Models
{
    public class Dicionario
    {
        public static Dictionary<string, Animais> animais = new Dictionary<string, Animais>{
            {TubaraoMartelo , new TubaraoMartelo },
        };
    }
}