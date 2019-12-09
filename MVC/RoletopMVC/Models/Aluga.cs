using System;

namespace RoleTopMVC.Models
{
    public class Aluga
    {
        public Cliente Cliente {get;set;}
        public string TipoEvento {get;set;}
        public bool Publico {get;set;}
        public bool Iluminacao {get;set;}
        public bool Som {get;set;}
        public string FormaPagamento {get;set;}
        public double ValorTotal{get;set;}
        public bool Pago {get;set;}
        public uint Status {get;set;}
        public Aluga(Cliente cliente, string tipoEvento, bool publico, bool iluminacao, bool som, string formaPagamento, double valorTotal, bool pago, uint status)
        {
            this.Cliente = new Cliente();
            this.TipoEvento = tipoEvento;
            this.Publico = false;
            this.Iluminacao = false;
            this.Som = false;
            this.FormaPagamento = formaPagamento;
            this.ValorTotal = 0;
            this.Pago = false;
            this.Status = status;

        }

        public Aluga()
        {
            
        }

    }

}