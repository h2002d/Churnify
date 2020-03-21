using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Churnify.Domain.Models;

namespace Churnify.Web.App.ViewModels.Customers
{
    public class CustomerSearchModel
    {
        public List<Customer> Customers { get; set; }
        public string Query { get; set; }
    }
}
