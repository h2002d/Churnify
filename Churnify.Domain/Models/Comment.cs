using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Churnify.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public int CommentTypeId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Range(1,10)]
        public double Rating { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public CommentType CommentType { get; set; }
        public Customer Customer { get; set; }
    }
}
