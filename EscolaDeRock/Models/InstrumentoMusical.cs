using System;
using EscolaDeRock.Models;

namespace EscolaDeRock.Models {
    public class InstrumentoMusical {
        public string[] notas = { "Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si" };

        public string TocarMusica () {
            int nota = new Random ().Next (notas.Length - 1);
            return notas[nota];
        }
    }
}