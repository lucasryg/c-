using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.ViewModels;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        public IActionResult Index()
        {
            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburguerRepository.ObterTodos();
            pedido.Shakes = shakeRepository.ObterTodos();

            var emailCliente = ObterUsuarioSession();
            if (!string.IsNullOrEmpty(emailCliente))
            {
                pedido.Cliente = clienteRepository.ObterPor(emailCliente);
            }

            var nomeUsuario = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuario))
            {
                pedido.NomeCliente = nomeUsuario;
            }
            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            {
                if (clienteLogado != null)
                {
                    pedido.Cliente = clienteLogado;
                }
            }

            pedido.NomeView = "Pedido";
            pedido.UsuarioEmail = ObterUsuarioSession();
            pedido.UsuarioNome = ObterUsuarioNomeSession();

            return View(pedido);
        }
        
        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            
            Pedido pedido = new Pedido();

            var nomeShake = form["shake"];

            Shake shake = new Shake(
            nomeShake,
            shakeRepository.ObterPrecoDe(nomeShake));

            pedido.Shake = shake;
            
            var nomeHamburguer = form["hamburguer"];
            
            Hamburguer hamburguer = new Hamburguer(
                nomeHamburguer,
                hamburguerRepository.ObterPrecoDe(nomeHamburguer));

            pedido.Hamburguer = hamburguer;
            
            

            Cliente cliente = new Cliente(){
            Nome = form["nome"],
            Endereco = form["endereco"],
            Telefone = form["telefone"],
            Email = form["email"],
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if(pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso");
            }else{
                return View("Error");
            }
        }
    }
}