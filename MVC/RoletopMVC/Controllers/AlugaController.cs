using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AlugaController : AbstractController
    {
        // AlugaRepository alugaRepository = new AlugaRepository();

        [HttpGet]
        public IActionResult Rent()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Rent",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }



        // public IActionResult RegistrarAluguel(IFormCollection form)
        // {
        //     ViewData["Action"] = "Rent";
        //     try
        //     {
        //     //! Olhar model.aluga para fazer isso
        //         Cliente aluga = new Cliente(
        //             form["nome"],
        //             form["email"],
        //             form["cpf"],
        //             form["telefone"],
        //             DateTime.Parse(form["dataEhora"])
        //         ); 
        //         System.Console.WriteLine("==================");
        //         System.Console.WriteLine(form["nome"]);
        //         System.Console.WriteLine(form["email"]);
        //         System.Console.WriteLine(form["cpf"]);
        //         System.Console.WriteLine(form["telefone"]);
        //         System.Console.WriteLine(form["dataEhora"]);
        //         System.Console.WriteLine("==================");

        //         alugaRepository.Inserir(aluga);

        //         return View("Sucesso", new RespostaViewModel()
        //         {
        //             NomeView = "Rent",
        //             UsuarioEmail = ObterUsuarioSession(),
        //             UsuarioNome = ObterUsuarioNomeSession()
        //         });

        //     }
        //     catch(Exception e)
        //     {
        //         System.Console.WriteLine(e.StackTrace);
        //         return View("Erro", new RespostaViewModel()
        //         {
        //             NomeView = "Cadastro",
        //             UsuarioEmail = ObterUsuarioSession(),
        //             UsuarioNome = ObterUsuarioNomeSession()
        //         });
        //     }
    }
}
        
