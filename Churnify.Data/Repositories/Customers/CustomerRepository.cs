using Churnify.Data.Data;
using Churnify.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Data.Repositories.Customers
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<IReadOnlyList<Customer>> GetCustomers(int page, int pageCount)
        {
            return await context.Customers.Skip((page-1)* pageCount).Take(pageCount).ToListAsync(); 
        }
        public async Task<IReadOnlyList<Customer>> GetCustomersBySearchQuery(string query)
        {
            return await context.Customers.Where(x=>x.PhoneNumber.Contains(query)||x.Email.Contains(query)).ToListAsync(); 
        }
    }
}
