using Microsoft.AspNetCore.Mvc;

namespace KSEB.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
