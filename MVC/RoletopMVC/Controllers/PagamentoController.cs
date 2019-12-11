using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Repositories;
using RoleTopMVC.Controllers;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;
using RoleTopMVC.Enum;

namespace RoletopMVC.Controllers
{
    public class PagamentoController : AbstractController
    {

        PagamentoRepository pagamentoRepository = new PagamentoRepository();

        TiposDeEventoRepository tiposDeEventoRepository = new TiposDeEventoRepository();

        AlugaRepository alugaRepository = new AlugaRepository();

        ClienteRepository clienteRepository = new ClienteRepository();
        
        PubPrivRepository pubPrivRepository = new PubPrivRepository();
        
        DebCreRepository debCreRepository = new DebCreRepository();
        
 
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
            AlugaViewModel avm= new AlugaViewModel();

            avm.TipoDeEvento = tiposDeEventoRepository.ObterTodos();
            avm.PublicoPrivado = pubPrivRepository.ObterTodos();
            avm.DebitoCredito = debCreRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                avm.cliente = clienteLogado;
            }

            avm.NomeView="Pagamento";
            avm.UsuarioEmail = usuarioLogado;
            avm.UsuarioNome = nomeUsuarioLogado;

            return View(avm);

        }

        public IActionResult Registrar(IFormCollection form)
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
            form["vencimento"],
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

        public IActionResult Reprovar(ulong id)
        {
            var aluga = alugaRepository.ObterPor(id);
            aluga.Status = (uint) StatusAluga.REPROVADO;

            if(alugaRepository.Atualizar(aluga))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
    }
}