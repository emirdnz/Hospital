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
    public class Room<T> : GenericBase<Room>, IRoom
    {
        public Task<int> Create(Entity.Room entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Room entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Room>> GetAll(Expression<Func<Entity.Room, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Room>> GetAllInclude(Expression<Func<Entity.Room, bool>> filter = null, params Expression<Func<Entity.Room, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Room?> GetBy(Expression<Func<Entity.Room, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Room entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Room?> IBaseRepo<Entity.Room>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
