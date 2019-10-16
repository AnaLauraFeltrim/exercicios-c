using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Models;

namespace EscolaDeRock
{
    class program
    {
        static void Main(string[] args){
            InstrumentoMusical generico = new InstrumentoMusical();
            System.Console.WriteLine(generico.TocarMusica());

            Violao violao1 = new Violao();
            System.Console.WriteLine("Violao: " + violao1.TocarMusica());

            Bateria bateria1 = new Bateria();
            System.Console.WriteLine("Bateria: " + bateria1.TocarMusica());

            Baixo baixo1 = new Baixo();
            System.Console.WriteLine("Baixo: " + baixo1.TocarMusica());

            ContraBaixo contraBaixo1 = new ContraBaixo();
            System.Console.WriteLine("ContraBaixo:" + contraBaixo1.TocarMusica());

            Guitarra guitarra1 = new Guitarra();
            System.Console.WriteLine("Guitarra: " + guitarra1.TocarMusica());

            Tambores  tambor1 = new Tambores();
            System.Console.WriteLine("Tambor: " + tambor1.TocarMusica());

            Teclado teclado1 = new Teclado();
            System.Console.WriteLine("Teclado" + teclado1.TocarMusica( ));
            }
    }
}