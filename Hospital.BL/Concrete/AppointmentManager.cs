﻿using Hospital.BL.Abstract;
using Hospital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL.Concrete
{
    public class AppointmentManager : ManagarBase<Appointment> , IAppointmentService
    {
    }
}
