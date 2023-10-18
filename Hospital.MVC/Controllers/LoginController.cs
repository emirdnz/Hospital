using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
