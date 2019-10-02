namespace Byte_Bank
{
    public class Conta
    {
        public int Cpf {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}

        public Conta(string Cpf, string Nome, string Email){
            this.Nome = Nome;
            this.Cpf = int.Parse(Cpf);
            this.Email = Email; 
        }

        public bool TrocaSenha(string senha){
            if((senha.Length> 6) && (senha.Length < 16)){
                return true; 
            } else {
                return false;
            }
        }
    }
}