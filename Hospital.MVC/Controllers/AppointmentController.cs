using Hospital.MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class AppointmentController : Controller
    {



        public IActionResult Index() { return View(); }

        [HttpPost]
        public IActionResult cretaeappointment(Appointment model)
        {
            var value = model.name;
            var value2 = model.phone;
            var value3 = model.email;
            var value4 = model.date;
            var value5 = model.time;


            return View();

        }


    }



}