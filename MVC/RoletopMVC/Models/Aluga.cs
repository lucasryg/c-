using System;

namespace RoleTopMVC.Models
{
    public class Aluga
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public uint Status {get;set;}
        public Aluga(string nome, string email,string cpf, string telefone, DateTime dataNascimento)
        {
            this.Id = 0;
            this.Cliente = new Cliente();
        }

        public Aluga()
        {
            
        }
        
    }

}