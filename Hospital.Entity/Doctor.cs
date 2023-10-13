using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Doctor : BaseEntity
    {

        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string Branch { get; set; }
        public int PersonalCode { get; set; }

        public string? GSM { get; set; }
        public string? Email { get; set; }


        public ICollection<Appointment?> Appointments { get; set; }


    }
}