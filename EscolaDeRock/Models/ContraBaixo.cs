namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo ritmo do contra-baixo");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do contra-baixo");
            return true;
        }
    }
}