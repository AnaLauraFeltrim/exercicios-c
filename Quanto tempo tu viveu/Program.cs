using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            Console.WriteLine("Idade: ");
            idade = int.Parse (Console.ReadLine());

            Console.WriteLine ("Quanto tempo você já viveu em meses: ");
            Console.WriteLine ($"{idade}*{12} = {idade * 12}");
            Console.WriteLine("Em dias: ");
            Console.WriteLine ($"{idade * 12}*{30} = {idade*12*30}");
            Console.WriteLine("Em horas: "); 
            Console.WriteLine($"{idade*12*30}*{24} = {idade*12*30*24}");
            Console.WriteLine("Em minutos: ");
            Console.WriteLine($"{idade*12*30*24}*{60} = {idade*12*30*24*60}");

            if(idade >= 60){
                Console.WriteLine("ta meio velho mano" );
            }
            else{
                Console.WriteLine("ta suave mano");
            }


        }
    }
}
