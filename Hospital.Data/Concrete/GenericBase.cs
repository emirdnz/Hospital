using Hospital.Data.Abstract;
using Hospital.Data.Context;
using Hospital.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Concrete
{
    public class GenericBase<T> : IBaseRepo<T>
       where T : BaseEntity


    {

        public readonly HospitalContext context;

        public GenericBase()
        {
            this.context = new HospitalContext();
        }

        public async Task<int> Create(T entity)
        {
            context.Set<T>().Add(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> Update(T entity)
        {
            context.Set<T>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
                return await context.Set<T>().Where(filter).ToListAsync();
            else
                return await context.Set<T>().ToListAsync();
        }

        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;
            if (filter != null)
            {
                query = context.Set<T>().Where(filter);
            }
            else
            {
                query = context.Set<T>();
            }
            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        }

        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await context.Set<T>().Where(filter).FirstOrDefaultAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }


    }
}
