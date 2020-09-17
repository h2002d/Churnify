using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class CustomerTask
    {
        public int Id { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string UserName { get; set; }
        public int StepId { get; set; }
        [ForeignKey("CustomerTaskType")]
        public int TaskTypeId { get; set; }
        public CustomerTaskType TaskType { get; set; }
    }
}
