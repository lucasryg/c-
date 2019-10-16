using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models {
    public class Violao : InstrumentoMusical, IHarmonia {
        public bool TocarAcorde () {
            System.Console.WriteLine ("Tocando acordes de violao.");
            return true;
        }
    }

}