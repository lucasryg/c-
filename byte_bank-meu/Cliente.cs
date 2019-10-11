using System;

namespace byte_bank
{
    public class Cliente
    {
        public string _Cpf;
        public string _Nome; 
        public string _Email; 
        private string _Senha;

        public string Senha
        {
            get {return _Senha;}
        }

        public string Cpf
        {
            get {return _Cpf;}
            set {_Cpf = value;}
        }

        public string Email
        {
            get { return _Email;}
            set { _Email = value;}
        }

        //Construtores
        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
        public bool TrocaSenha(string Senha){
            if((Senha.Length > 6) && Senha.Length < 16){
                this._Senha = Senha;     
                return true;
            } else{
                return false;
            }
        }
    }
}