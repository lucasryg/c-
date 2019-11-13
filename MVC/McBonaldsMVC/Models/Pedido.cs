using System;

namespace McBonaldsMVC.Models
{
    public class Pedido
    {
        public Cliente cliente {get;set;}
        public Hamburguer hamburguer {get;set;}
        public Shake shake {get;set;}
        public DateTime DataDoPedido {get;set;}
        public double PrecoTotal {get;set;}
        
    }
}