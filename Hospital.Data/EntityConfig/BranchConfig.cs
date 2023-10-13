using Hospital.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.EntityConfig
{
    public class BranchConfig : BaseConfig<Branch>
    {
        public override void Configure(EntityTypeBuilder<Branch> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.BranchName).HasMaxLength(50);

        }
    }
}
