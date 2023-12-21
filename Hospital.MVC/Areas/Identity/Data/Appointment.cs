using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Hospital.MVC.Areas.Identity.Data
{
    public class Appointment
    {
        public string name { get; set; }

        public string phone { get; set; }

        public EmailAddressAttribute email { get; set; }

        public DateFormat date { get; set; }

        public DateTime time { get; set; }
    }
}
