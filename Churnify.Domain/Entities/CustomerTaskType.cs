using System;
using System.Collections.Generic;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class CustomerTaskType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WorkflowId { get; set; }

    }
}
