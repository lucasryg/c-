using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class NavController : Controller
    {
        public IActionResult Calendario()
        {
            return View();
        }

        public IActionResult Galeria()
        {
            return View();
        }
    }
}