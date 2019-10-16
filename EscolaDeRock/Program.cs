using System;
using System.Collections.Generic;
using EscolaDeRock.Models;
using EscolaDeRock.interfaces;

namespace EscolaDeRock
{
    class Program
    {
        enum FormacaoEnum : int 
        {
            TRIO = 3,
            QUARTETO
        };
        enum instrumentosEnum : int 
        {
            BAIXO,
            BATERIA,
            CONTRABAIXO,
            GUITARRA,
            TECLADO,
            TAMBORES,
            VIOLAO,
        };

        enum CatergoriaEnum : int
        {
            HAMONIO,
            PERCUSSÃO,
            MELODIA,
        };

        static void Main(string[] args)
        {
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CatergoriaEnum));

            var opcoesFormacao = new List<string>()
            {
                "       - 0                          ",
                "       - 1                        "
            };

            int opcoesFormacaoSelecionada = 0;
            string menuBar = "========================================";

            do
            {
                
                bool formacaoEscolhida = false;

                do
                {
                    #region Area do menu
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("    Seja Bem-Vindo!     ");
                    System.Console.WriteLine("    Escolha uma formação:  ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    for(int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = itensMenuPrincipal[i];
                        if(opcoesFormacaoSelecionada == i)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(opcoesFormacao);
                            Console.ResetColor();
                        }
                        else{
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
                        }
                    }

                    var key = Console.ReadKey(true).Key;

                    switch(key){
                        case ConsoleKey.UpArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == 0 ? opcoesFormacaoSelecionada : --opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.DownArrow:
                        opcoesFormacaoSelecionada = opcoesFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcoesFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        formacaoEscolhida = true;
                        break;
                    }
                    
                    #endregion
                }while(false);
                
            }while(!querSair);
        }
    }
}
