using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class Customer : BaseEntity
    {
        [Key]
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
