using Churnify.Domain.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IReadOnlyList<CommentType> CommentTypes { get; set; }
        public List<SelectListItem> CommentTypesList => CommentTypes.Select(n => new SelectListItem
    {
        Value = n.Id.ToString(),
        Text = n.Name.ToString()
    }).ToList();

    }
}
