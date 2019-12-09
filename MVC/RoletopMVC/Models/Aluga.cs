using System;

namespace RoleTopMVC.Models
{
    public class Aluga
    {
        public Cliente Cliente {get;set;}
        public string TipoEvento {get;set;}
        public string Publico {get;set;}
        public string Iluminacao {get;set;}
        public string Som {get;set;}
        public string FormaPagamento {get;set;}
        public string NumeroCartao {get;set;}
        public string NomeCartao {get;set;}
        public string venc
        public uint Status {get;set;}
        public Aluga(Cliente cliente, string tipoEvento, string publico, string iluminacao, string som, string formaPagamento, uint status)
        {
            this.Cliente = new Cliente();
            this.TipoEvento = tipoEvento;
            this.Publico = publico;
            this.Iluminacao = iluminacao;
            this.Som = som;
            this.FormaPagamento = formaPagamento;
            this.Status = status;

        }

        public Aluga(string tipoEvento, string publico, string iluminacao, string som, string formaPagamento, uint status)
        {
            this.TipoEvento = tipoEvento;
            this.Publico = publico;
            this.Iluminacao = iluminacao;
            this.Som = som;
            this.FormaPagamento = formaPagamento;
            this.Status = status;
        }



        public Aluga()
        {
            
        }

    }

}