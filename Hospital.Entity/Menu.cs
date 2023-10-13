using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entity
{
    public class Menu : BaseEntity
    {
        public string MenuAdi { get; set; }
        public string? Area { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public string? Css { get; set; }
        public string? Icon { get; set; }

        public int? RoleID { get; set; }
        public Role? Role { get; set; }
    }
}