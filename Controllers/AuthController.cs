using Microsoft.AspNetCore.Mvc;

namespace webApplicationFineCorso.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
