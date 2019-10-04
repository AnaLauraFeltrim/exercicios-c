namespace Byte_Bank
{
    public class ContaCorrente
    {
        public Conta Titular {get; set;}
        public int Agencia {get; set;}
        public int NumeroDaConta {get; set;}
        public double Saldo {get; set;}

        public ContaCorrente (int Agencia, int NumeroDaConta, Conta Titular){
            this.Saldo = Saldo;
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

        public double Deposito(double deposito){
            this.Saldo += valor;
            return this.Saldo;

        }

        public bool Saque (double saque){
            if(valor <= this.Saldo){
                this.Saldo -= valor;
                return true;
            }else{
                return false;
            }
        }

        public bool Tranferencia (ContaCorrente destino, double valor){
            if (this.Saque (valor)){
                destino.Deposito(valor);
                return true;
            }else{
                return false;
            }
        }
    }
}
