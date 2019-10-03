namespace Conta_Corrente
{
    public class ContaCorrente
    {
        public string Titular {get; set;}
        public int Agencia {get; set;}
        public int NumeroDaConta {get; set;}
        public double Saldo {get; set;}

        public ContaCorrente (int Agencia, int NumeroDaConta, string Titular){
            Saldo = 0;
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.NumeroDaConta = NumeroDaConta;

        }

        public bool SaldoNegativo (double saldo){
            if (saldo < 0){
                return false;
            }else {
                return true;
            }
        }
    }
}
