using System;
using RoleTopMVC.Enum;

namespace RoleTopMVC.Models
{
    public class Aluga
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
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

        public Aluga(Cliente cliente)
        {
            this.Cliente = new Cliente();
        }

        public Aluga(string tipoEvento, string publico, string iluminacao, string som, string formaPagamento, string numeroCartao, string nomeCartao, string dataVencimento, string cvv)
        {
            this.TipoEvento = tipoEvento;
            this.Publico = publico;
            this.Iluminacao = iluminacao;
            this.Som = som;
            this.FormaPagamento = formaPagamento;
            this.NumeroCartao = numeroCartao;
            this.NomeCartao = nomeCartao;
            this.DataVencimento = dataVencimento;
            this.CVV = cvv;
            this.Status = (uint) StatusAluga.PENDENTE;
            this.Id = 0;
        }



        public Aluga()
        {
            
        }

    }

}