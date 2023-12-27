using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class AppointmentListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
