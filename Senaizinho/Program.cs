using System;

namespace Senaizinho {
    class Program {
        static void Main (string[] args) {
            Aluno[] alunos = new Aluno[5];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[10];
            int salasCadastradas = 0;

            string opcao;

            do {
                
                System.Console.WriteLine ("Bem vindo, o que deseja fazer? ");
                System.Console.WriteLine ("1 - Cadastrar alunos");
                System.Console.WriteLine ("2 - Cadastrar sala ");
                System.Console.WriteLine ("3 - Alocar aluno");
                System.Console.WriteLine ("4 - Remover aluno");
                System.Console.WriteLine ("5 - Verificar salas");
                System.Console.WriteLine ("6 - Verificar alunos");
                System.Console.WriteLine ("0 - Sair");

                opcao = Console.ReadLine ();

                Aluno aluno = new Aluno ();
                Sala sala = new Sala ();

                switch (opcao) {
                    case "1":
                        Console.Clear ();

                        System.Console.WriteLine ("Nome do aluno: ");
                        aluno.nome = Console.ReadLine ();

                        System.Console.WriteLine ("Data de nascimento: ");
                        aluno.dataNasc = DateTime.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Curso: ");
                        aluno.curso = Console.ReadLine ();


                        alunos[alunosCadastrados] = aluno;
                        alunosCadastrados++;

                        break;

                    case "2":
                        Console.Clear ();

                        System.Console.WriteLine ("Número da sala: ");
                        sala.numeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ($"Capacidade atual: {alunosCadastrados} ");
                        System.Console.WriteLine("Capacidade máxima: 10"); 
                        salas[salasCadastradas] = sala;
                        salasCadastradas++;

                        break;

                    case "3":
                        System.Console.WriteLine (" Em que sala deseja colocar o aluno? ");
                        int salaAlocar = int.Parse(Console.ReadLine());
                        foreach(var item in salas){
                            
                        }
                        
                        
                        
                        break;

                    case "4":
                        System.Console.WriteLine ("Qual aluno deseja remover? ");
                        Console.ReadLine ();
                        break;

                    case "5":
                        foreach(var item in salas){
                            if(item != null){
                                Console.Clear();
                                
                                System.Console.WriteLine("-----------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.numeroSala} ");
                                System.Console.WriteLine($"Capacidade total: {item.capacidadeTotal}");
                                System.Console.WriteLine("-----------------------------------------");
                            }    
                        }
                        break;

                    case "6":
                        foreach(var item in alunos){
                            if(item != null){
                                Console.Clear();
                                System.Console.WriteLine("-----------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine($"Curso: {item.curso}");
                                System.Console.WriteLine($"Sala: {item.numeroSala}");
                                System.Console.WriteLine("-----------------------------------------");                              
                            }
                        }
                        break;

                }

            } while (opcao != "0");

        }
    }
}