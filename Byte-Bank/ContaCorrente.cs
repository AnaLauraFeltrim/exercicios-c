namespace Byte_Bank
{
    public class ContaCorrente
    {
        public Conta Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        private double _saldo; 

        public double Saldo{
            get {return _saldo;}
        }

        



        public ContaCorrente(int Agencia,int Numero, Conta Titular){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this._saldo = 0.0;
        }

        public double Deposito(double valor){
            if(valor < 0){
                return false;
                
            }else{
                this._saldo += valor;
                return true;
            }
            
        }
        public bool Saque(double valor){
            
            if(valor <= this._saldo){
            this._saldo -= valor;
            return true;
            } else{
                return false;
            }
            }
            
        
        public bool Transferencia(ContaCorrente destino, double valor){
            if (this.Saque(valor)){
                destino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }
    }
}
