using Churnify.Data.Data;
using Churnify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext context;

        public RepositoryBase(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<T> Create(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

    }
}
