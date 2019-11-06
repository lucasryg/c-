using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models {
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia 
    {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo o ritmo do Contrabaixo");
            return true;
        }

        public bool TocarAcorde () {
            System.Console.WriteLine ("Tocando acordes do Contrabaixo");
            return true;
        }
    }
}