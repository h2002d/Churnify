using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Churnify.Core.Services.Customers;
using Churnify.Domain.Models;
using Churnify.Web.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Churnifiy.Web.App.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(int id)
        {
            var customer = await _customerService.GetById(id);
            var model = new CustomerDetailViewModel();
            model.Customer=_mapper.Map<Customer>(customer);
            return View(model);
        }



        public IActionResult CustomersPartialView(int page, int pageCount)
        {
            _customerService.GetCustomers(page, pageCount);
            return PartialView();
        }
    }
}
