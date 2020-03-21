using Churnify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Data.Repositories.Customers
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public Task<IReadOnlyList<Customer>> GetCustomers(int page, int pageCount);
        public Task<IReadOnlyList<Customer>> GetCustomersBySearchQuery(string query);
    }
}
