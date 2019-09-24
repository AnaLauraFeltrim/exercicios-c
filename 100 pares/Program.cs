using System;

namespace _100_pares
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 1;
            

            Console.WriteLine("100 primeiros ímpares: ");

            for(num=1; num<99; num++){

                if(num%2!=0){
                Console.WriteLine($"{num+2}");
                }
                
                

            }
        }
    }
}
