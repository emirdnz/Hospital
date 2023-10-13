using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Branch : BaseEntity
    {
        public string BranchName { get; set; }

        public ICollection<Doctor>? Doktorlar { get; set; }
    }
}
