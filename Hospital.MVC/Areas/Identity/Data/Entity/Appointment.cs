using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Hospital.MVC.Areas.Identity.Data.Entity
{
    public class Appointment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public  string Email { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }
        // date'i timeonly yaptığımda  ve time datetime yapıtığımda entity hatası alıyorum 
    }
}
