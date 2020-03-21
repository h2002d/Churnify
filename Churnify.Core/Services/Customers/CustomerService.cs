using AutoMapper;
using Churnify.Domain.Dto;
using Churnify.Data.Repositories.Customers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Core.Services.Customers
{
    public class CustomerService : ServiceBase<Churnify.Domain.Entities.Customer, Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
            : base(customerRepository, mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Customer>> GetCustomers(int page, int pageCount)
        {
            var customers = await _customerRepository.GetCustomers(page, pageCount);
            return _mapper.Map<IReadOnlyList<Customer>>(customers);
        }

        public async Task<IReadOnlyList<Customer>> GetCustomersBySearchQuery(string query)
        {
            var customers = await _customerRepository.GetCustomersBySearchQuery(query);
            return _mapper.Map<IReadOnlyList<Customer>>(customers);
        }
    }
}
