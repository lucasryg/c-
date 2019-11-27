using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "cliente_email"; 
        protected const string SESSION_CLIENTE_NOME="cliente_nome"; 

        protected string ObterUsuarioSession()
        {
          var Usuario =  HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
          if (!string.IsNullOrEmpty(Usuario))
          {
              return Usuario;
          }else{
              return "";
          }
        
        }
          protected string ObterUsuarioNomeSession()
        {
          var nomeUsuario =  HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
          if (!string.IsNullOrEmpty(nomeUsuario))
          {
              return nomeUsuario;
          }else{
              return "";
          }
        
        }
    }
}