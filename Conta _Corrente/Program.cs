using System;

namespace Conta_Corrente {
    class Program {

        private static bool contaOk;
        static void Main (string[] args) {

            System.Console.WriteLine ("Titular da conta: ");
            string titular = Console.ReadLine ();
            System.Console.WriteLine ("Agência do titular");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Número da conta");
            int numerodaconta = int.Parse (Console.ReadLine ());

            ContaCorrente novaconta = new ContaCorrente (agencia, numerodaconta, titular);

            do {
                System.Console.WriteLine ("Insira o saldo:");
                double saldo = double.Parse (Console.ReadLine ());
                bool contaOk = novaconta.SaldoNegativo (saldo);
                if (!contaOk) {
                    System.Console.WriteLine ("Não foi possível criar sua conta");
                } else {
                    System.Console.WriteLine ("Parabéns. Sua conta foi criada com sucesso");
                }

            }while(!contaOk);
        }
    }
}