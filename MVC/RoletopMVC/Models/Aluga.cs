using System;
using RoleTopMVC.Enum;

namespace RoleTopMVC.Models
{
    public class Aluga
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public DateTime DataPedido {get;set;}
        public string TipoEvento {get;set;}
        public string Publico {get;set;}
        public string Iluminacao {get;set;}
        public string Som {get;set;}
        public string FormaPagamento {get;set;}
        public string NumeroCartao {get;set;}
        public string NomeCartao {get;set;}
        public string DataVencimento {get;set;}
        public string CVV {get;set;} 
        public uint Status {get;set;}

        public Aluga()
        {
            this.Cliente = new Cliente();
            this.Status = (uint) StatusAluga.PENDENTE;
            this.Id = 0;
        }


    }

}