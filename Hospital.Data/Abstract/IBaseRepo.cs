using Hospital.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Data.Abstract
{
    public interface IBaseRepo<T> where T : class
    {

        public HospitalContext context { get; set; }
        Task<int> Create(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);

        Task<T?> GetById(int id);

        Task<T?> GetBy(Expression<Func<T, bool>> filter);
        Task<ICollection<T>> GetAll();
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);

        Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include);
    }

}
