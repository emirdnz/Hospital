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
    public class Secretary<T> : GenericBase<Secretary>, ISecretary
    {
        public Task<int> Create(Entity.Secretary entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Secretary entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Secretary>> GetAll(Expression<Func<Entity.Secretary, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Secretary>> GetAllInclude(Expression<Func<Entity.Secretary, bool>> filter = null, params Expression<Func<Entity.Secretary, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Secretary?> GetBy(Expression<Func<Entity.Secretary, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Secretary entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Secretary?> IBaseRepo<Entity.Secretary>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
