using System;

namespace salário
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 0;
            


            Console.WriteLine("Insira seu salário: ");
            salario = double.Parse(Console.ReadLine());

            

            if(salario >= 500){
                Console.WriteLine("Você não tem direito a aumento");
            }

            else{
                Console.WriteLine($"{salario}*{1.3} = {salario*1.3}");
                Console.WriteLine("Seu salário foi reajustado :)");
            }



        }
    }
}
