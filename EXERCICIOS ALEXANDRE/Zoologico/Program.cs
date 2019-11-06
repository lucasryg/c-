using System;
using System.Collections.Generic;
using Zoologico.Interfaces;
using Zoologico.Models;

namespace Zoologico {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine("-------ZOOLOGICO-------");
            System.Console.WriteLine("Escolha o animal para ser alocado: ");
            var codigo = 0;
            foreach (var animals in Dicionario.animais.Values)
            {
                System.Console.WriteLine($"{"",5}{++codigo} - {animals.GetType().Name}");
            }
            
            

        }

        public static void ClassificarAnimais
    }
}
