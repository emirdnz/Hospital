using Hospital.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class AppointmentController : Controller
    {



        public IActionResult Index() { return View(); }

       
        
        
        [HttpPost]
        public IActionResult Index(Appointment model)
        {
            var value = model.Name;
            var value2 = model.Phone;
            var value3 = model.Email;
            var value4 = model.Date;
            var value5 = model.Time;


            return View();

        }


    }



}