using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentTime { get; set; }


        public int PatientId { get; set; }
        public Patient Patients { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctors { get; set; }

        public int RoomId { get; set; }
        public Room RoomName { get; set; }
    }
}
