using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models {
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo o ritmo do Baixo");
            return true;
        }
        public bool TocarAcorde () {
            System.Console.WriteLine ("Tocando acordes do Baixo");
            return true;
        }
    }
}