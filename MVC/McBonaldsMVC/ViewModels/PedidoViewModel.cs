using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes { get; set; }
        public Cliente Cliente {get;set;}
            public string NomeCliente {get;set;}

        public PedidoViewModel() //lista vazia para não qubrar o código
        {   
            this.Hamburgueres = new List<Hamburguer>();
            this.Shakes = new List<Shake>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }

    }
}