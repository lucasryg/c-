using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models {
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia {
        public bool TocarAcorde () {
            System.Console.WriteLine ("Tocando acordes da Guitarra");
            return true;
        }

        public bool TocarSolo () {
            System.Console.WriteLine ("Tocando solo da Guitarra");
            return true;
        }
    }
}