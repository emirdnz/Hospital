using Hospital.MVC.Areas.Identity.Data;
using Hospital.MVC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.MVC.Controllers
{

    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly ILogger<AppointmentController> _logger;
        private readonly UserManager<HospitalMVCUser> _userManager;
        private readonly HospitalDbContext context;

        public AppointmentController(ILogger<AppointmentController> logger, UserManager<HospitalMVCUser> userManager, HospitalDbContext context)
        {
            _logger = logger;
            this._userManager = userManager;
            this.context = context;
        }


        //GET

        public async Task<IActionResult> Index()
        {
            return context.Users != null ?
                View(await context.Users.ToListAsync()) :
                Problem("users is null");
        }




        //Post

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> User()
        {
            
            
            
            if (!ModelState.IsValid)
            {
                context.Add(User);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");   
            }

            return View(User);


        }





    }
}