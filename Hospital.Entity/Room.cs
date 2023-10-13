using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Room : BaseEntity
    {

        public string RoomName { get; set; }



        public ICollection<Appointment>? Appointments { get; set; }


    }
}
