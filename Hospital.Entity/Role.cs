using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
        public ICollection<Menu>? Menuler { get; set; }
    }
}
