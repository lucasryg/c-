using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class AlugaViewModel : BaseViewModel
    {
        public List<string> DebitoCredito {get;set;}
        public List<string> TipoDeEvento {get;set;}
        public List<string> PublicoPrivado {get;set;}
        public List<Cliente> Cliente {get;set;}
        public List<Aluga> Aluga {get;set;}
        public Cliente cliente {get;set;}

        public string NomeUsuario {get;set;}

        public AlugaViewModel()
        {
            this.DebitoCredito = new List<string>();
            this.PublicoPrivado = new List<string>();
            this.TipoDeEvento = new List<string>();
            this.Cliente = new List<Cliente>();
            this.Aluga = new List<Aluga>();
            this.NomeUsuario = "dewn";
        }

        
    }
}