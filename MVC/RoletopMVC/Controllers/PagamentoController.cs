using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;
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
    }
}