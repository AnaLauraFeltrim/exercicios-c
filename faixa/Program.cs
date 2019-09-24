using System;

namespace faixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0 ;
            int anoAtual = 2019;
            int idade ;
            


            Console.WriteLine("Insira seu ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            idade = anoAtual - ano;



            if(idade <= 2){
                Console.WriteLine("Recém-Nascido");

            }

            else if((idade <= 11) && (idade >=3)){
                Console.WriteLine("Criança");
            }

            else if((idade>=12) && (idade <=19)){
                Console.WriteLine("Adolescente");
            }

            else if((idade>=20) && (idade <=65)){
                Console.WriteLine("Adulto");
            }
            
            else if(idade>=65){
                Console.WriteLine("Idoso");
            }

            else if(idade>=200){
                Console.WriteLine("Como caralhos você ta vivo");
            }

            


        }
    }
}
