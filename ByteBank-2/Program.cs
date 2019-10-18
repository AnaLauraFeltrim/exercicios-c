using System;
using ByteBank_2.Models;

namespace ByteBank_2._0 {
    class Program {
        static void Main (string[] args) {
            string cliente1 = "Alexandre";
            string cliente2 = "cesar";

            #region Testa Conta Corrente
            ContaCorrente contaCorrente = new ContaCorrente (1, 1, cliente1);
            ContaEspecial contaEspecial = new ContaEspecial (1, 2, cliente2);
            contaCorrente.Deposito (10);
            #endregion
    
    

        }
        public static void DepositarConta (ContaBancaria contaBancaria) {
                System.Console.WriteLine ("ByteBank - Depósito");
                System.Console.WriteLine ("--------------------------");
                System.Console.WriteLine ();
                string usuario = contaBancaria.Titular;
                System.Console.WriteLine ($"Conta:{contaBancaria.GetType()}");
                Console.WriteLine ($"Bem-vindo - {usuario}");
                Console.WriteLine ($"Agência: {contaBancaria.Agencia}   Conta: {contaBancaria}");
                Console.WriteLine ($"Saldo: {contaBancaria.Saldo}");
            }
    }
}