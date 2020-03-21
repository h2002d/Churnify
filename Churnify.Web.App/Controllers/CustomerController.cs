using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Churnify.Core.Services.Customers;
using Churnify.Domain.Models;
using Churnify.Web.App.ViewModels.Customers;
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
            model.Customer = _mapper.Map<Customer>(customer);
            return View(model);
        }

        public async Task<IActionResult> Search(string query)
        {
            var customers = await _customerService.GetCustomersBySearchQuery(query);
            var model = new CustomerSearchModel();
            model.Query = query;
            if (customers != null && customers.Count > 1)
            {
                model.Customers = _mapper.Map<List<Customer>>(customers);
                return View(model);
            }
            else if (customers.Count == 1)
            {
                return RedirectToAction("Index", new { id = customers.FirstOrDefault().Id });
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult CustomersPartialView(int page, int pageCount)
        {
            _customerService.GetCustomers(page, pageCount);
            return PartialView();
        }


        public async Task<IActionResult> Create(int id)
        {
            var customer = await _customerService.GetById(id);
            CustomerCreateViewModel model = _mapper.Map<CustomerCreateViewModel>(customer);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateViewModel customer)
        {
            var customerNew = await _customerService.Add(_mapper.Map<Churnify.Domain.Dto.Customer>(customer));
            return RedirectToAction("Index", new { id = customerNew.Id });
        }
    }
}
