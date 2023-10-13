﻿using Hospital.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.EntityConfig
{
    public class DoctorConfig : BaseConfig<Doctor>
    {
        public override void Configure(EntityTypeBuilder<Doctor> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DoctorName).HasMaxLength(50);
            builder.Property(p => p.DoctorSurname).HasMaxLength(50);


        }
    }
}
