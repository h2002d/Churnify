using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Churnify.Data.Entities
{
    public class Comments : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CommentType")]
        public int CommentTypeId { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public double Rating { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public CommentType CommentType { get; set; }
        public Customers Customer { get; set; }
    }
}
