using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidosController : AbstractController {
    
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository ();
        ShakeRepository shakesRepository = new ShakeRepository (); //Shake repositorio em branco tem que ser igual a 
        public IActionResult Index () // colocar o nome do arquivo que está na página 
        {
            PedidoViewModel pvm = new PedidoViewModel ();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos ();

            pvm.Shakes = shakesRepository.ObterTodos (); // o shake repository que esta em verde

            var emailCliente =  ObterUsuarioSession();
            if(!string .IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }
            

            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                pvm.NomeCliente = nomeUsuario;
            }
            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = ObterUsuarioSession();
            pvm.UsuarioNome = ObterUsuarioNomeSession();
            return View (pvm);
        }

        public object Registrar (IFormCollection form) {
            Shake shake = new Shake ();
            Pedido pedido = new Pedido ();
            var nomeShake = form["shake"];
            shake = new Shake (nomeShake, shakesRepository.ObterPrecoDe (nomeShake));
            shake.Nome = form["shake"];
            shake.preco = shakesRepository.ObterPrecoDe (nomeShake);


            pedido.Shake = shake; //!
            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (nomeHamburguer, hamburguerRepository.ObterPrecoDe (nomeHamburguer));
            hamburguer.Nome = form["hamburguer"];
            hamburguer.preco = 0.0;

            pedido.Hamburguer = hamburguer; //!

            Cliente cliente = new Cliente ();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente; //!

            pedido.DataDoPedido = DateTime.Now; //!Now pega a data e a hora

            pedido.PrecoTotal = hamburguer.preco + shake.preco; //!

            if (pedidoRepository.Inserir (pedido)) {
                return View ("Sucesso", new BaseViewModel()
                {
                    NomeView = "Sucesso",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()

                });
            } else {
                return View ("Erro",new BaseViewModel(){
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession(),
                });
            }
        }
    }
}