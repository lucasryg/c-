using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class PedidoRepository : RepositoryBase {
        private const string PATH = "Database/Pedido.csv";

        public PedidoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Pedido pedido) {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            pedido.Id = (ulong) ++quantidadePedidos; 

            var linha = new string[] { PrepararPedidoCVS (pedido) };

            File.AppendAllLines (PATH, linha);

            return true;

        }

        public List<Pedido> ObterTodosPorCliente (string emailCliente)

        {
            var pedidos = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach (var pedido in pedidos)
            {
                if (pedido.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }
        public List<Pedido> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Pedido> pedidos = new List<Pedido> ();

            foreach (var linha in linhas) {
                Pedido pedido = new Pedido ();
                pedido.Id = ulong.Parse(ExtrairValorDoCampo("id",linha));
                pedido.Hamburguer= new Hamburguer();
                pedido.Shake = new Shake();
                pedido.Cliente = new Cliente();
                pedido.Cliente.Nome = ExtrairValorDoCampo ("cliente_nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo ("cliente_endereco", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo ("cliente_email", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo ("cliente_telefone", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo ("hamburguer_nome", linha);
                pedido.Hamburguer.preco = double.Parse (ExtrairValorDoCampo ("hamburguer_preco", linha));
                pedido.Shake.Nome = ExtrairValorDoCampo ("shake_nome", linha);
                pedido.Shake.preco = double.Parse (ExtrairValorDoCampo ("shake_preco", linha));
                pedido.PrecoTotal = double.Parse (ExtrairValorDoCampo ("preco_total", linha));
                pedido.DataDoPedido = DateTime.Parse (ExtrairValorDoCampo ("data_pedido", linha));

                pedidos.Add (pedido);
            }
            return pedidos;
        }
        

        private static string PrepararPedidoCVS (Pedido pedido) {
            Cliente cliente = pedido.Cliente;
            Hamburguer hamburguer = pedido.Hamburguer;
            Shake shake = pedido.Shake;

            return $"id={pedido.Id};status_pedido={pedido.Status};cliente_nome={cliente.Nome};cliente_email={cliente.Email};cliente_endereco={cliente.Endereco};cliente_telefone={cliente.Telefone};hamburguer_preco={hamburguer.preco};hamburguer_nome={hamburguer.Nome};shake_nome={shake.Nome};shake_preco={shake.preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}"; //substituição do bloco
        }
    }
}