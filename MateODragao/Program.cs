using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            

            do {

                System.Console.WriteLine ("------------------------------");
                System.Console.WriteLine ("        Mate o Drragão        ");
                System.Console.WriteLine ("------------------------------");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreira guerreira = CriarGuerreiro ();

                        Dragao dragao = CriarDragao();

                        /* INÍCIO - primeiro diálogo */

                        CriarDialogo (guerreira.Nome, $" {dragao.Nome} vai tomar no cu");
                        CriarDialogo (guerreira.Nome, "Pega no meu pau, vou enfiar minha espada no seu coraçao, bobão.\n");

                        CriarDialogo (dragao.Nome, "KKKKKKKKKKKKKKK! Ih ala ta pensando que é quem, seu otário?\n");

                        FinalizarDialogo ();

                        /* FIM - primeiro diálogo */

                        /* INÍCIO - segundo diálogo */

                        CriarDialogo (guerreira.Nome, $"E te interessa agora porque? Meu nome é {guerreira.Nome} {guerreira.Sobrenome}, agora vem pro fight, filhão.");
                        CriarDialogo (guerreira.Nome, $"Vim do {guerreira.CidadeNatal} pra te meter a porrada.");
                        CriarDialogo (dragao.Nome,  "Mas quem te perguntou? Vou te usar de carvão no meu nargas.");

                        FinalizarDialogo ();

                        /* FIM - segundo diálogo */

                        bool jogadorAtacaPrimeiro = guerreira.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreira = guerreira.Força > guerreira.Inteligencia ? guerreira.Força + guerreira.Destreza : guerreira.Inteligencia + guerreira.Destreza;

                        /*INÍCIO da Treta */

                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();
                            System.Console.WriteLine ("-------------Turno do jogador-------------");
                            System.Console.WriteLine ("Escolha sua ação");
                            System.Console.WriteLine ("1 - Atacar");
                            System.Console.WriteLine ("2 - Fugir");
                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTot = guerreira.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTot = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTot > dragaoDestrezaTot) {
                                        System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Parece que alguém se fodeu, precisa nem esperar o câncer pra morrer.");
                                        dragao.Vida -= (poderAtaqueGuerreira + 5);
                                        System.Console.WriteLine ("--------------");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP guerreira: {guerreira.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: KKKKKKK conseguiu errar ainda.");
                                    }
                                    break;

                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: To dando o fora daqui, ta ligado meu irmão.");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Volta aqui carvão de bosta, quero fumar porra.");
                                    break;

                            }

                            FinalizarDialogo ();

                            while (dragao.Vida > 0 && guerreira.Vida > 0 && jogadorNaoCorreu) {
                                System.Console.WriteLine ("----------Turno do Dragão----------");
                                Random geradorNumeroAleatorio = new Random ();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTot = guerreira.Destreza + numeroAleatorioJogador;
                                int dragaoDestrezaTot = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTot > guerreiroDestrezaTot) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Já ta virando carvão, TOPTOP");
                                    guerreira.Vida -= dragao.Força;
                                    System.Console.WriteLine ("--------------");
                                    System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP guerreira: {guerreira.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Vem tranquilo, vem tranquilo");
                                }

                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();

                                /*início - turno jogador */
                                Console.Clear ();

                                System.Console.WriteLine ("-------------Turno do jogador-------------");
                                System.Console.WriteLine ("Escolha sua ação");
                                System.Console.WriteLine ("1 - Atacar");
                                System.Console.WriteLine ("2 - Fugir");
                                opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                        guerreiroDestrezaTot = guerreira.Destreza + numeroAleatorioJogador;
                                        dragaoDestrezaTot = dragao.Destreza + numeroAleatorioDragao;

                                        if (guerreiroDestrezaTot > dragaoDestrezaTot) {
                                            System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: Parece que alguém se fodeu, precisa nem esperar o câncer pra morrer.");
                                            dragao.Vida -= (poderAtaqueGuerreira + 5);
                                            System.Console.WriteLine ("--------------");
                                            System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP guerreira: {guerreira.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: KKKKKKK conseguiu errar ainda.");
                                        }

                                        if (guerreira.Vida <= 0) {
                                            System.Console.WriteLine ("SE FODEU KKK");
                                        }

                                        if (dragao.Vida <= 0) {
                                            System.Console.WriteLine ("É TETRAAAAAAA");
                                        }

                                        System.Console.WriteLine ();
                                        System.Console.WriteLine ($"{dragao.Nome}");
                                        System.Console.WriteLine ($"{guerreira.Nome}");

                                        break;

                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreira.Nome.ToUpper()}: To dando o fora daqui, ta ligado meu irmão.");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Volta aqui carvão de bosta, quero fumar porra.");
                                        break;

                                }

                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();

                                /*fim - turno jogador */
                            }

                        }

                        /*FIM da Treta */

                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        break;

                    default:
                        System.Console.WriteLine ("Comando inválido, bobão");
                        break;
                }
            }
            while (jogadorNaoDesistiu);

        }

        private static void CriarDialogo (string nome, string frase) {
            System.Console.WriteLine ($"{nome.ToUpper()}: {frase}!");
        }

        private static void FinalizarDialogo () {
            Console.WriteLine ();
            System.Console.WriteLine ("Aperte ENTER para continuar");
            Console.ReadLine ();
            Console.Clear ();

        }

        private static Guerreira CriarGuerreiro () {
            Guerreira guerreira = new Guerreira ();
            guerreira.Nome = "Tia";
            guerreira.Sobrenome = "May";
            guerreira.CidadeNatal = "Brooklyn";
            guerreira.DataNascimento = DateTime.Parse ("09/08/1150");
            guerreira.FerramentaAtaque = "Espada";
            guerreira.FerramentaProtecao = "Armadura de Couro";
            guerreira.Força = 3;
            guerreira.Destreza = 3;
            guerreira.Inteligencia = 2;
            guerreira.Vida = 20;

            return guerreira;
        }

        private static Dragao CriarDragao () {
            Dragao dragao = new Dragao ();
            dragao.Nome = "Dragonildo";
            dragao.Força = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }
    }
}