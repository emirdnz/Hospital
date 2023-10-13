using Hospital.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.EntityConfig
{
    public class PatientConfig : BaseConfig<Patient>
    {
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.PatientName).HasMaxLength(50);
            builder.Property(p => p.PatientSurname).HasMaxLength(50);

        }
    }
}
