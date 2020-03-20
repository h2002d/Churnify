using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class CommentType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
