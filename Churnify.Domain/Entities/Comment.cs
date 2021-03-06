﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Churnify.Domain.Entities
{
    public class Comment : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CommentType")]
        public int CommentTypeId { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public string UserId { get; set; }
        public double Rating { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public CommentType CommentType { get; set; }
        public Customer Customer { get; set; }
    }
}
