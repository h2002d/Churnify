using System;
using System.Collections.Generic;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class Transitions
    {
        public int Id { get; set; }
        public int WorkflowId { get; set; }
        public int CurrentStepId { get; set; }
        public int NextStepId { get; set; }
        public string Name { get; set; }
    }
}
