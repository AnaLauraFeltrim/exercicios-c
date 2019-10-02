using System;

namespace Byte_Bank {
    class Program {
        static void Main (string[] args) 
        {

            Conta conta = new Conta();

            System.Console.WriteLine ("Nome: ");
            conta.Nome = Console.ReadLine ();

            System.Console.WriteLine ("CPF: ");
            conta.Cpf = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Email: ");
            conta.Email = Console.ReadLine ();

            System.Console.WriteLine ("Senha: ");
            conta.Senha = Console.ReadLine ();

        }

    }
}