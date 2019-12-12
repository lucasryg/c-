using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
    public List<Aluga> Aluga {get;set;} 

    public HistoricoViewModel()
    {
        this.Aluga = new List<Aluga>();
    }
    }
}
