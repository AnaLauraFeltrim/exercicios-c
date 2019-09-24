using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0;

            do{
            


            Console.Write("Insira o número ou 0 para terminar: ");
            num1 = int.Parse(Console.ReadLine());

            if(num1 % 2 == 0){
                Console.WriteLine("O número é par");
            }

            else{
                Console.WriteLine("O número é impar");
            }

            }while(num1 != 0);

        }
    }
}
