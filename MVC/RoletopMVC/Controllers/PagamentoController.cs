using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class PagamentoController : AbstractController
    {
        public IActionResult Pagar()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Pagar",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });            
        }

        public IActionResult Pagar(IFormCollection form)
        {
            //Vem do Model.Aluga
            // Pagamento repositoty aqui
            

            
        }
    }
}