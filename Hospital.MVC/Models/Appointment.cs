using System.ComponentModel.DataAnnotations;

namespace Hospital.MVC.Models
{
    public class Appointment
    {
        public string name { get; set; }

        public string phone { get; set; }

        public EmailAddressAttribute email {  get; set; }   

        public DateOnly date {  get; set; } 
        
        public DateTime time { get; set; }  
    }
}
