using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                Console.Clear ();
                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();

                        Guerreiro guerreiro = CriarGuerreiro ();

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragonaldo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INCIO - PRIMEIRO DIÁLOGO */
                        CriarDialogo (guerreiro.Nome, $"{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe!");
                        CriarDialogo (dragao.Nome, "Humano tolinho, quem pensas que és?");

                        FinalizarDialogo ();

                        /* FIM - PRIMEIRO DIÁLOGO */

                        /* INICIO - SEGUNDO DIÁLOGO */
                        CriarDialogo (guerreiro.Nome, $"Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ò criatura morfética");
                        CriarDialogo (guerreiro.Nome, $"Vim de {guerreiro.CidadeNatal} para te derrotar e mostrar meu valor!");
                        CriarDialogo (dragao.Nome, $"QUEM? DE ONDE? Bom, que seja... Fritar-te-ei e devorar-te-ei, primata insolente!");
                        System.Console.WriteLine ("BAMBAM: Tá na hora do show!");

                        FinalizarDialogo ();

                        /* FIM - SEGUNDO DIÁLOGO */
                        Console.Clear ();
                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro) {
                            System.Console.WriteLine ("**Turno do Jogador**");
                            System.Console.WriteLine ("Escolha uma ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        CriarDialogo (guerreiro.Nome, "TOMA ESSA, MALDITO!");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        CriarDialogo (dragao.Nome, "Você é muito fraco!");
                                    }

                                    break;
                                case "2":
                                    CriarDialogo (guerreiro.Nome, "FUI! Flw Vlw");
                                    CriarDialogo (dragao.Nome, "SOOO EZZZ BRO");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        FinalizarDialogo ();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu) {
                            Random geradorNumeroAleatorio = new Random ();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;
                            Console.Clear ();
                            System.Console.WriteLine ("**Turno do Dragão**");

                            if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Fritou o forévis, foi?");
                                guerreiro.Vida = guerreiro.Vida - dragao.Forca;
                                System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                            } else {
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: EEEEEERROU! ");
                            }

                            FinalizarDialogo ();

                            Console.Clear ();

                            System.Console.WriteLine ("**Turno do Jogador**");
                            System.Console.WriteLine ("Escolha uma ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    geradorNumeroAleatorio = new Random ();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        CriarDialogo (guerreiro.Nome, "TOMA ESSA, MALDITO!");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        CriarDialogo (dragao.Nome, "Você é muito fraco!");
                                    }

                                    break;
                                case "2":
                                    CriarDialogo (guerreiro.Nome, "FUI! Flw Vlw");
                                    CriarDialogo (dragao.Nome, "SOOOO EZZZ BROO");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }

                        if (guerreiro.Vida <= 0) {
                            System.Console.WriteLine ("YOU LOSE!");
                        }
                        if (dragao.Vida <= 0) {
                            System.Console.WriteLine ("YOU WIN!");
                        }

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine ("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine ("Comando Inválido!");
                        break;
                }
            } while (jogadorNaoDesistiu);

        }

        public static void CriarDialogo (string nome, string frase) {
            System.Console.WriteLine ($"{nome.ToUpper()}: \n-{frase}");
        }

        public static void FinalizarDialogo () {
            System.Console.WriteLine ();
            System.Console.WriteLine ("Aperte ENTER para prosseguir!");
            Console.ReadLine ();
            Console.Clear ();
        }

        public static Guerreiro CriarGuerreiro () {
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = "Ragnar ";
            guerreiro.Sobrenome = "Lothbrouk";
            guerreiro.CidadeNatal = "Suiça";
            guerreiro.DataNascimento = DateTime.Parse ("31/03/500");
            guerreiro.FerramentaProtecao = "Capa com pele de dragao";
            guerreiro.FerramentaAtaque = "Espada flamejante com veneno";
            guerreiro.Forca = 3;
            guerreiro.Destreza = 2;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 20;

            return guerreiro;
        }

    }

}