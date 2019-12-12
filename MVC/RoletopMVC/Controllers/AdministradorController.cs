using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Repositories;
using RoleTopMVC.Enum;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PagamentoRepository pagamentoRepository= new PagamentoRepository();
        public IActionResult Dashboard()
        {
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) {

                var alugas = pagamentoRepository.ObterTodos();

                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var aluga in alugas) {
                    switch (aluga.Status) {
                        case (uint) StatusAluga.APROVADO:
                            dashboardViewModel.PedidosAprovados++;
                            break;
                        case (uint) StatusAluga.REPROVADO:
                            dashboardViewModel.PedidosReprovados++;
                            break;
                        default:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel.alugas.Add (aluga);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel(){
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });

            }
        }
    }
}