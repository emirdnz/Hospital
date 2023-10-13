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
    public class Doctor<T> : GenericBase<Doctor>, IDoctor
    {
        public Task<int> Create(Entity.Doctor entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Doctor entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Doctor>> GetAll(Expression<Func<Entity.Doctor, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Doctor>> GetAllInclude(Expression<Func<Entity.Doctor, bool>> filter = null, params Expression<Func<Entity.Doctor, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Doctor?> GetBy(Expression<Func<Entity.Doctor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Doctor entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Doctor?> IBaseRepo<Entity.Doctor>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
