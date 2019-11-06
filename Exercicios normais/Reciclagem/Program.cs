using System;
using System.Collections.Generic;
using System.Linq;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem {

    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("------Auxiliar de reciclagem------");
            System.Console.WriteLine ("Qual desses lixos voce deseja jogar fora?");
            System.Console.WriteLine ("1 - Garrafa");
            System.Console.WriteLine ("2 - GarrafaPET");
            System.Console.WriteLine ("3 - GuardaChuva");
            System.Console.WriteLine ("4 - Latinha");
            System.Console.WriteLine ("5 - Papelao");
            System.Console.WriteLine ("6 - PoteManteiga");
            int codigo = int.Parse(Console.ReadLine());
            

        }
        public static void Reciclar(TiposLixo lixo)
        {

            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

            if (tipoLixo.Equals(typeof(IPapel)))
            {
                Papelao papelao = new Papelao();
                ReciclarNovo(papelao);
            }
            else if (tipoLixo.Equals(typeof(IMetal)))
            {
                IMetal lixoConvertido = (IMetal)lixo;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.ReciclarTipoMetal()} deve ir para a lixeira Amarela");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IPlastico)))
            {
                IPlastico lixoConvertido = (IPlastico)lixo;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.ReciclarTipoPlastico()} deve ir para a lixeira Vermelha");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IVidro)))
            {
                IVidro lixoConvertido = (IVidro)lixo;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.ReciclarTipoVidro()} deve ir para a lixeira Verde");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IOrganico)))
            {
                IOrganico lixoConvertido = (IOrganico)lixo;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.ReciclarTipoOrganico()} deve ir para a Composteira");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IIndefinido)))
            {
                IIndefinido lixoConvertido = (IIndefinido)lixo;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                System.Console.WriteLine($"{lixoConvertido.ReciclarComo()} deve ir para o descarte especial");
                Console.ResetColor();
            }
            else
            {
                System.Console.WriteLine("Tipo não identificado!");
            }
            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
        }

        public static bool ReciclarNovo(IPapel papel){
           return "Seu lixo é o da cor Azul - Papel";
        }
        // ReciclarNovo(IMetal metal){}
        // ReciclarNovo(IPlastico plastico){}
        // ReciclarNovo(IVidro vidro){}
        // ReciclarNovo(IOrganico organico){}
        // ReciclarNovo(IIndefinido indefinido){}


        



    }
}