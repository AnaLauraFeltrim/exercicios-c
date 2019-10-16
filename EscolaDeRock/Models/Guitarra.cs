using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando Guitarra");
            return true;
        }

        public bool TocarSolo(){
            System.Console.WriteLine("Tocando solo de guitarra");
            return true;
        }

    }
}