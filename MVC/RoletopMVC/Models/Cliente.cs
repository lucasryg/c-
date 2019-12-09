using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Cpf {get;set;}
        public string Telefone {get;set;}
        public DateTime DataNascimento {get;set;} 
        public uint TipoUsuario {get;set;}


    public Cliente()
    {

    }

    
    public Cliente(string nome,string email, string senha, string cpf, string telefone, DateTime dataNascimento)
    {
        this.Nome = nome;
        this.Email = email;
        this.Senha = senha;
        this.Cpf = cpf;
        this.Telefone = telefone;
        this.DataNascimento = dataNascimento;
    }

    public Cliente(string nome,string email, string cpf, string telefone, DateTime dataNascimento)
    {
        this.Nome = nome;
        this.Email = email;
        this.Cpf = cpf;
        this.Telefone = telefone;
        this.DataNascimento = dataNascimento;
    }
    }
}