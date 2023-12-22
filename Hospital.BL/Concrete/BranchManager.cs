using Hospital.BL.Abstract;
using Hospital.Data.Abstract;
using Hospital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL.Concrete
{
    public class BranchManager : ManagarBase<Branch>, IBranchService
    {
        public BranchManager(IBaseRepo<Branch> repository) : base(repository)
        {
        }
    }
}
