using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.Models {
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia {
        public bool TocarAcorde () {
            System.Console.WriteLine ("Tocando acordes do Piano");
            return true;
        }

        public bool TocarSolo () {
            System.Console.WriteLine ("Tocando soolo do Piano");
            return true;
        }
    }
}