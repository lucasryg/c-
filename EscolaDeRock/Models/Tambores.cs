using System;
using EscolaDeRock.interfaces;
namespace EscolaDeRock.Models {
    public class Tambores : InstrumentoMusical, IPercussao {
        public bool ManterRitmo () {
            System.Console.WriteLine ("Mantendo o ritmo do Tambor");
            return true;
        }
    }
}