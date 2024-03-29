﻿using Hospital.BL.Abstract;
using Hospital.Data.Concrete;
using Hospital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL.Concrete
{
    public class ManagarBase<T> : IManagerService<T> where T : BaseEntity
    {
        public readonly GenericBase<T> repository;

        public ManagarBase()
        {
            this.repository = new GenericBase<T>();
        }

        public async Task<int> CreateAsync(T entity)
        {
            return await repository.Create(entity);
        }



        public async Task<int> DeleteASync(T entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {

            return await repository.GetAll(filter);
        }

        public async Task<IQueryable<T>> GetAllIncludeAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            return await repository.GetAllInclude(filter, include);
        }

        public async Task<T?> GetByAsync(Expression<Func<T, bool>> filter)
        {
            return await repository.GetBy(filter);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<int> UpdateAsync(T entity)
        {
            return await repository.Update(entity);
        }
    }
}
