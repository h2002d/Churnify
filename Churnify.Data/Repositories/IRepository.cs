using Churnify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
