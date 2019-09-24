using System;

namespace login_e_senha
{
    class Program
    {
        static void Main(string[] args)
        {

            string credencial;
            string senha; 

            Console.WriteLine("Login");
            credencial = Console.ReadLine();

            Console.WriteLine("Senha");
            senha = Console.ReadLine();

            if((credencial == "admin")&&(senha == "lasanha")){
                Console.WriteLine("Bem vindo, ADM");

            }

            else{
                Console.WriteLine("Bem vindo, Usuário");

            }

            
        }
    }
}
