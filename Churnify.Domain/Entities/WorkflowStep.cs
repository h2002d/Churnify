using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class WorkflowStep
    {
        [ForeignKey("Step")]
        public int StepId { get; set; }
        [ForeignKey("Workflow")]
        public int WorkflowId { get; set; }
    }
}
