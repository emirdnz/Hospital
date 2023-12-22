using Hospital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL.Abstract
{
    public interface IManagerService<T> where T : BaseEntity
    {
        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteASync(T entity);

        Task<T?> GetByIdAsync(int id);

        Task<T?> GetByAsync(Expression<Func<T, bool>> filter);
        Task<ICollection<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);

        Task<IQueryable<T>> GetAllIncludeAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include);


    }
}
