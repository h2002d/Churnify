using Churnify.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Churnify.Web.App.ViewModels.Comments
{
    public class CustomerCommentViewModel
    {
        public List<Comment> Comments { get; set; }
        public Customer Customer { get; set; }
    }
}
