using System;

namespace Byte_Bank {
    class Program {

        private static bool senhaOk;
        private static bool contaOk;
        static void Main (string[] args) 
        
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("         ByteBank");
            System.Console.WriteLine("----------------------------");

            System.Console.WriteLine($"CPF:");
            string Cpf = Console.ReadLine();
            
            System.Console.WriteLine($"Nome:");
            string Nome = Console.ReadLine();
            
            System.Console.WriteLine($"Email:");
            string Email = Console.ReadLine();
            
            Conta login1 = new Conta(Nome,Cpf,Email);

            do{
                System.Console.WriteLine("Digite a Senha");
                string senha = Console.ReadLine();
                bool senhaOk = login1.TrocaSenha(senha);
                if(!senhaOk){
                    System.Console.WriteLine("Senha não atende aos requsitos");
                } else {
                    System.Console.WriteLine("Senha Trocada com sucesso");
                }
            }while(!senhaOk);

            System.Console.WriteLine ("Titular da conta: ");
            string titular = Console.ReadLine ();
            System.Console.WriteLine ("Agência do titular");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número da conta");
            int numerodaconta = int.Parse (Console.ReadLine ());

            ContaCorrente novaconta = new ContaCorrente (agencia, numerodaconta,login1);
            ContaCorrente.Saldo = saldo;
            
            do {
                System.Console.WriteLine ("Insira o saldo:");
                saldo = double.Parse (Console.ReadLine ());
                bool contaOk = novaconta.SaldoNegativo (saldo);
                if (!contaOk) {
                    System.Console.WriteLine ("Não foi possível criar sua conta");
                } else {
                    System.Console.WriteLine ("Parabéns. Sua conta foi criada com sucesso");
                }

            }while(!contaOk);

            
            Console.Clear();
            System.Console.WriteLine("ByteBank - Seja Bem-Vindo");
            System.Console.WriteLine("O que deseja fazer? ");
            System.Console.WriteLine("1 - Depósito");
            System.Console.WriteLine("2 - Saque");
            System.Console.WriteLine("3 - Tranferência");

            string opcao = Console.ReadLine();
            
            switch(opcao){
                case "1":
                Console.Clear();
                System.Console.WriteLine("Valor depositado");
                double deposito = double.Parse(Console.ReadLine());
                System.Console.WriteLine($"Saldo atual igual a {saldo + deposito}");
                break;

                case "2":
                Console.Clear();
                System.Console.WriteLine("Valor a ser sacado: ");
                double saque = double.Parse(Console.ReadLine());
                if(saque > saldo){
                    System.Console.WriteLine("Você não tem limite para retirar esse valor");
                }else {
                    System.Console.WriteLine("Saque efetuado com sucesso");
                }
                break;

                case "3":
                Console.Clear();
                System.Console.WriteLine("Quanto deseja transferir? ");
                double transferencia = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Número da conta: ");
                Console.ReadLine();
                System.Console.WriteLine("Destinatário: ");
                Console.ReadLine();
                break;

            }
            


        

        
        


        }
    }
}