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
    public class Appointment<T> : GenericBase<Appointment>, IAppointment
    {
        public Task<int> Create(Entity.Appointment entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Appointment entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Appointment>> GetAll(Expression<Func<Entity.Appointment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Appointment>> GetAllInclude(Expression<Func<Entity.Appointment, bool>> filter = null, params Expression<Func<Entity.Appointment, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Appointment?> GetBy(Expression<Func<Entity.Appointment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Appointment entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Appointment?> IBaseRepo<Entity.Appointment>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
