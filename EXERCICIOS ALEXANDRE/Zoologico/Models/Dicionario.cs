using System.Collections.Generic;

namespace Zoologico.Models
{
    public class Dicionario
    {
        public static Dictionary<int, Animais> animais = new Dictionary<int, Animais>{
            {1 , new TubaraoMartelo()},
            {2 , new Tucano()},
            {3 , new Arara()},
            {4 , new Leao()},
            {5 , new Orangotango()},
            {6 , new Chipanze()},
            {7 , new Pinguim()},
            {8 , new Tartaruga()},
            {9 , new Golfinho()},
        };
    }
}