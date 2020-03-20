using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Churnify.Core.Services.Comments;
using Churnify.Domain.Models;
using Churnify.Web.App.ViewModels.Comments;
using Microsoft.AspNetCore.Mvc;

namespace Churnify.Web.App.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public async Task<IActionResult> CustomerPartial(int customerId)
        {
            var model = new CustomerCommentViewModel();
            var comments = await _commentService.GetCustomerComments(customerId);
            model.Comments = _mapper.Map<List<Comment>>(comments);
            model.Customer = new Customer { Id = customerId };
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Comment comment)
        {
            //_commentService.Add(comment);
            return View();
        }
    }
}