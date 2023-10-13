using Hospital.Data.Abstract;
using Hospital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Concrete
{
    public class UserRepository : GenericBase<Users>, IUsers
    {
    }
}
