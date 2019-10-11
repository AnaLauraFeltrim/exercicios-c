using System;

namespace Byte_Bank {
    class Program {

        private static bool senhaOk;
        private static bool contaOk;
        static void Main (string[] args) 
        
        {
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Cpf: ");
            string cpf = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Conta cliente1 = new Conta(nome,cpf,email);

            bool TrocouSenha = false;
            do{
                Console.Write("Digite a Senha: ");
                string senha = Console.ReadLine();
                TrocouSenha = cliente1.TrocaSenha(senha);
                if (!TrocouSenha){
                    Console.WriteLine("Senha nao atende aos requisitos");
                } else {
                    Console.WriteLine("Senha Trocada com sucesso");
                }
            }while(!TrocouSenha);

            Console.WriteLine("Cadastro de Conta Corrente");
            Console.WriteLine();
            Console.Write("Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            Console.Write("Conta: ");
            int conta = int.Parse(Console.ReadLine());
            //Console.Write("Titular: ");
            //string titular = Console.ReadLine();

            bool _saldoValido = false;
            double _saldo;
            do{
                Console.Write("Digite o saldo: ");
                _saldo = double.Parse(Console.ReadLine());
                if (_saldo >= 0){
                    _saldoValido = true;
                } else {
                    Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!_saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente(agencia,conta,cliente1);
            contaCorrente.Deposito(_saldo);
            contaCorrente.Agencia = 123;

            Console.WriteLine("ByteBank - Deposito");
            Conta usuario = contaCorrente.Titular;
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Deposito(_saldo)}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            _saldo = contaCorrente.Deposito(valor);
            Console.WriteLine($"_saldo atual: {_saldo}");
            Console.WriteLine();

            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"_saldo: {contaCorrente.Saque(_saldo)}");
            Console.Write("Qual o valor do Saque? ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                Console.WriteLine("Saque realizado com sucesso. Retire as notas");
            } else {
                Console.WriteLine("Não foi possivel realizar a operação");

            }
            Console.WriteLine($"_saldo atual: {contaCorrente.Saque(_saldo)}");
            Console.WriteLine();

            Conta cliente2 = new Conta("Alexandre","123.321.123-12","a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123,132,cliente2);
            Console.WriteLine("ByteBank - Transferencia");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"origem: {contaCorrente.Saldo}");
            Console.WriteLine($"destino: {contaCorrente2.Saldo}");
            Console.Write("Digite o valor da tranferência: ");
            valor = double.Parse(Console.ReadLine());
        
            if (contaCorrente.Transferencia(contaCorrente2,valor)){
                Console.WriteLine("Tranferencia efetuada com sucesso.");
            } else {
                Console.WriteLine("Operação não pode ser realizada.");
            }
            Console.WriteLine($"Saldo origem: {contaCorrente.Deposito(_saldo)}");
            Console.WriteLine($"saldo destino: {contaCorrente2.Deposito(_saldo)}");
            


        

        
        


        }
    }
}