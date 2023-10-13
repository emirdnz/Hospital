using Hospital.Data.Abstract;
using Hospital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Concrete
{
    public class Patient<T> : GenericBase<Patient>, IPatient
    {
        public Task<int> Create(Entity.Patient entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Patient entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Patient>> GetAll(Expression<Func<Entity.Patient, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Patient>> GetAllInclude(Expression<Func<Entity.Patient, bool>> filter = null, params Expression<Func<Entity.Patient, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Patient?> GetBy(Expression<Func<Entity.Patient, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Patient entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Patient?> IBaseRepo<Entity.Patient>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
