using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class AlugaViewModel : BaseViewModel
    {
        public List<string> TipoEvento {get;set;}
        public List<Cliente> Cliente {get;set;}
        public List<Aluga> Aluga {get;set;}

        public AlugaViewModel()
        {
            this.TipoEvento = new List<string>();
            this.Cliente = new List<Cliente>();
            this.Aluga = new List<Aluga>();
        }

        
    }
}