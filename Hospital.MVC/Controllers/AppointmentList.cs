using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class AppointmentList : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
