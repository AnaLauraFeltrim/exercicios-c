using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double media ;
            int chose = 0; 
            string oper;

            Console.WriteLine("Que operação deseja? 1-calculadora 2-média");
            chose = int.Parse(Console.ReadLine());

            if(chose == 1){

                Console.WriteLine("Digite o 1º número: ");
            num1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite O 2º Número: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual operador desejado");
            oper = Console.ReadLine() ;

            if(oper == "-"){
                Console.WriteLine($" {num1} - {num2} = {num1 - num2} ");
                }

            if(oper == "+"){
                Console.WriteLine($" {num1} + {num2} = {num1 + num2} ");
            }

            if(oper == "/"){
                Console.WriteLine($" {num1} / {num2} = {num1 / num2} ");
            }

            if(oper == "*"){
                Console.WriteLine($" {num1} * {num2} = {num1 * num2} ");
            }

            if(oper == "%"){
                 Console.WriteLine($" {num1} % {num2} = {num1 % num2} ");
            }
            }

            
            
            else{
            Console.WriteLine("Calcular média: ");

            Console.WriteLine("Nota 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nota 4: ");
            num4 = int.Parse(Console.ReadLine());

            
            media = (num1 + num2 + num3 + num4) /4;
            Console.WriteLine("Média: " +media);

            if(media >= 7){
                Console.WriteLine("Você foi aprovado");
            }

            else{
                Console.WriteLine("Tomou no cu mano");
            }
        }

            

            


           

            

            
        
    }
}}
