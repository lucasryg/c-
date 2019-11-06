using System;
using EscolaDeRock.interfaces;

namespace EscolaDeRock.Models {
    public class Bateria : InstrumentoMusical, IPercussao {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo o ritmo da Bateria");
            return true;
        }
    }
}