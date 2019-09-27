using System;

namespace mcBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Alexandre","55 11 9757875785","analaurafeltrim@gmail.com");
            Console.WriteLine("Nome: " + cliente1.Nome);
            System.Console.WriteLine("Telefone: " + cliente1.Telefone);
            System.Console.WriteLine("Email: " + cliente1.Email);

        }
        
            
        
    }
}
