using Hospital.MVC.Data;
using Hospital.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Hospital.MVC.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly HospitalDbContext _context;

        public AppointmentController(HospitalDbContext context)
        {
            this._context = context;
        }


        public IActionResult Index()
        {

            return _context.Appointments != null ?
                View(_context.Appointments.ToList()) : Problem("enitity set 'Appointments' is null");
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