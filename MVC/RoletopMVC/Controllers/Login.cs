using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class Login : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}