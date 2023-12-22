using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Patient : BaseEntity
    {

        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string TcNo { get; set; }

        public string? Email { get; set; }
        public string? GSM { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }
}
