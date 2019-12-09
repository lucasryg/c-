using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
        public class AlugaController : AbstractController {
                AlugaRepository alugaRepository = new AlugaRepository();

                [HttpGet]
                public IActionResult Rent () {
                    return View (new BaseViewModel () {
                        NomeView = "Rent",
                            UsuarioEmail = ObterUsuarioSession (),
                            UsuarioNome = ObterUsuarioNomeSession ()
                    });
                }

                public IActionResult RegistrarAluguel (IFormCollection form) {
                    try {
                        //! Olhar model.aluga para fazer isso
                        // Para a primeira pagina, que apenas precisa dos dados do cliente
                        Aluga aluga = new Aluga();
                        
                        Cliente cliente = new Cliente (){

                            Nome = form["nome"],
                            Email = form["email"],
                            Cpf = form["cpf"],
                            Telefone = form["telefone"],
                            DataNascimento = DateTime.Parse (form["dataEhora"])
                        };
                        
                        aluga.Cliente = cliente;

                        
                       alugaRepository.Inserir (aluga);

                        return View ("Sucesso", new RespostaViewModel () {
                            NomeView = "Rent",
                                UsuarioEmail = ObterUsuarioSession (),
                                UsuarioNome = ObterUsuarioNomeSession ()
                        });
                    } catch (Exception e) {
                        System.Console.WriteLine (e.StackTrace);
                        return View ("Erro", new RespostaViewModel () {
                            NomeView = "Cadastro",
                                UsuarioEmail = ObterUsuarioSession (),
                                UsuarioNome = ObterUsuarioNomeSession ()
                        });
                    }
                }
        }
}