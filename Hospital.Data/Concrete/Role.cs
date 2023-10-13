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
    public class Role<T> : GenericBase<Role>, IRole
    {
        public Task<int> Create(Entity.Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Entity.Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entity.Role>> GetAll(Expression<Func<Entity.Role, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Entity.Role>> GetAllInclude(Expression<Func<Entity.Role, bool>> filter = null, params Expression<Func<Entity.Role, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Entity.Role?> GetBy(Expression<Func<Entity.Role, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Entity.Role entity)
        {
            throw new NotImplementedException();
        }

        Task<Entity.Role?> IBaseRepo<Entity.Role>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
