using System;
using System.Collections.Generic;
using System.Text;

namespace Churnify.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int CommentTypeId { get; set; }
        public int CustomerId { get; set; }
        public string UserId { get; set; }
        public double Rating { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public CommentType CommentType { get; set; }
        public Customer Customer { get; set; }
    }
}
