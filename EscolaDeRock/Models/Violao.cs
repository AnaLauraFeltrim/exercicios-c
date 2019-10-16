using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do violão");
            return true;
        }

        public bool TocarAcordes(){
            System.Console.WriteLine("Tocar ");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo no violão");
            return true;
        }

    }
}
