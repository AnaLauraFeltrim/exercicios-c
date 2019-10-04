namespace Conta_Corrente
{
    public class ContaCorrente
    {
        public string Cliente {get; set;}
        public int Agencia {get; set;}
        public int NumeroDaConta {get; set;}
        public double Saldo {get; set;}

        public ContaCorrente (int Agencia, int NumeroDaConta, string Cliente){
            this.Saldo = Saldo;
            this.Cliente = Cliente;
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

        public double Deposito (double deposito){
            
            return Saldo; 
        }
    }
}
