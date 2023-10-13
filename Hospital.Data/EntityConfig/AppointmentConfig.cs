using Hospital.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.EntityConfig
{
    public class AppointmentConfig : BaseConfig<Appointment>
    {
        public override void Configure(EntityTypeBuilder<Appointment> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => new { x.DoctorId, x.RoomId, x.PatientId, x.AppointmentTime }).IsUnique();

        }
    }
}
