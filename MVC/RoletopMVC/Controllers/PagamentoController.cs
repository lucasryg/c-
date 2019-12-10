using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Repositories;
using RoleTopMVC.Controllers;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class PagamentoController : AbstractController
    {

        PagamentoRepository pagamentoRepository = new PagamentoRepository();

        TiposDeEventoRepository tiposDeEvenetoRepository = new TiposDeEventoRepository();


        public IActionResult FormaPag()
        {
            return View(new AlugaViewModel()
            {
                TipoEvento = tiposDeEvenetoRepository.ObterTodos()
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
            form["tipoEvento"],
            form["PubPriv"],
            form["iluminacao"],
            form["som"],
            form["formaDePagamento"],
            form["numero"],
            form["nome"],
            DateTime.Parse(form["vencimento"]),
            form["CVV"]
            //! Colocar os dados do cartao no Model.Aluga 
            );

            if (pagamentoRepository.Inserir(aluga))
            {
                return View ("Sucesso", new RespostaViewModel("Seu pedido foi realizado com sucesso")
                        {
                            NomeView = "Pagar",
                            UsuarioEmail = ObterUsuarioSession(),
                            UsuarioNome = ObterUsuarioNomeSession()
                        });
            }
            else{
                return View ("Erro", new RespostaViewModel("Não foi possivel cadastrar, tente novamente")
                        {
                            NomeView = "Pagar",
                            UsuarioEmail = ObterUsuarioSession(),
                            UsuarioNome = ObterUsuarioNomeSession()
                        });
            }
            //Agora, pedidoRepository (necessario {inserir})


            



        }
    }
}