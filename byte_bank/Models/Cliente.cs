using System;

namespace byte_bank.Models
{
    public class Cliente
    {
        public string Cpf;
        public string Nome; 
        public string Email; 
        public string Senha;

        //Construtores
        public Cliente(string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }
        public bool TrocaSenha(string Senha){
            if((Senha.Length > 6) && Senha.Length < 16){
                this.Senha = Senha;     
                return true;
            } else{
                return false;
            }
        }
    }
}