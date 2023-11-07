using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Users : BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TcNo { get; set; }

        public string? Email { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public int? Phone { get; set; }

        public ICollection<Appointment?> Appointments { get; set; }

       
        

    }
}
