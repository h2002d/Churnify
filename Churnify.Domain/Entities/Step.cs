using System;
using System.Collections.Generic;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class Step
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Roles { get; set; }
    }
}
