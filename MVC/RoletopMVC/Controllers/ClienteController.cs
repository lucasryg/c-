using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}