using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Churnify.Web.App.ViewModels.Customers
{
    public class CustomerCreateViewModel
    {
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string CreateUserId { get; set; }
    }
}
