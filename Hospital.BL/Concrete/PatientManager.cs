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
    public class PatientManager : ManagarBase<Patient>, IPatientService
    {
        public PatientManager(IBaseRepo<Patient> repository) : base(repository)
        {
        }
    }
}
