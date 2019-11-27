using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AlugaController : Controller
    {
        public IActionResult Rent()
        {
            return View();
        }
    }
}