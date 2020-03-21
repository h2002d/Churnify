using Churnify.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Core.Services.Customers
{
    public interface ICustomerService:IServiceBase<Customer>
    {
        Task<IReadOnlyList<Customer>> GetCustomers(int page,int pageCount);
        Task<IReadOnlyList<Customer>> GetCustomersBySearchQuery(string query);
    }
}
