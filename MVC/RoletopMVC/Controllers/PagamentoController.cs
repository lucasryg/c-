using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Controllers;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class PagamentoController : AbstractController
    {
        public IActionResult FormaPag()
        {
            return View(new BaseViewModel()
            {
                NomeView = "FormaPag",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });            
        }
        

        public IActionResult Pagar()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Pagar",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });            
        }

        public IActionResult Cash(IFormCollection form)
        {
            //Vem do Model.Aluga
            // Pagamento repositoty aqui

            Aluga aluga = new Aluga(
            form["tipoevento"],
            form["PuvPriv"],
            form["iluminacao"],
            form["som"],
            form["formaDePagamento"],
            form["numero"],
            form[""]

            //! Colocar os dados do cartao no Model.Aluga 
            );


            



        }
    }
}