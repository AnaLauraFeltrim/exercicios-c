using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Tocando a bateria");
            return true;
        }
    }
}