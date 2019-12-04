using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}