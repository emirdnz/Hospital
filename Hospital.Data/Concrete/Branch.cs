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
    public class Branch<T> : GenericBase<Branch>, IBranch
    {
        public Task<int> Create(Entity.Branch entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Branch entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Branch>> GetAll(Expression<Func<Entity.Branch, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Branch>> GetAllInclude(Expression<Func<Entity.Branch, bool>> filter = null, params Expression<Func<Entity.Branch, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Branch?> GetBy(Expression<Func<Entity.Branch, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Branch entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Branch?> IBaseRepo<Entity.Branch>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
