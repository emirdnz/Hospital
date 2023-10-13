using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Secretary : BaseEntity
    {
        public string SecretaryName { get; set; }
        public string SecretarySurname { get; set; }
        public int PersonalCode { get; set; }
        public ICollection<Appointment?> Appointments { get; set; }
    }
}
