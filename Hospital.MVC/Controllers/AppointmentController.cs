using Hospital.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Hospital.MVC.Controllers
{
    public class AppointmentController : Controller
    {



        public IActionResult Index()
        {
            return View();

        }




        [HttpPost]
        public IActionResult Index(Appointment model)
        {
            int AppointmentID = model.Id;
            string name = model.Name;
            string phone = model.Phone;
            string email = model.Email;
            string date = model.Date;
            string time = model.Time;   

            return View();

        }


    }



}