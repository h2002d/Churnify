using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Churnify.Core.Services.Comments;
using Churnify.Domain.Models;
using Churnify.Web.App.ViewModels.Comments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Churnify.Web.App.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly ICommentTypeService _commentTypeService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, ICommentTypeService commentTypeService, IMapper mapper)
        {
            _commentService = commentService;
            _commentTypeService = commentTypeService;
            _mapper = mapper;
        }

        public async Task<IActionResult> CustomerPartial(int customerId)
        {
            var model = new CustomerCommentViewModel();
            var comments = await _commentService.GetCustomerComments(customerId);
            model.Comments = _mapper.Map<List<Comment>>(comments).OrderByDescending(x=>x.Id).ToList();
            model.Customer = new Customer { Id = customerId };
            model.CommentTypes = _mapper.Map<List<CommentType>>(await _commentTypeService.All());
            return PartialView(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CreateDate = DateTime.Now;
                comment.UserId = User.Identity.Name;
                var model = await _commentService.Add(_mapper.Map<Churnify.Domain.Dto.Comment>(comment));
                return RedirectToAction("Index", "Customer", new { Id = model.CustomerId });
            }
            else
            {
                ModelState.AddModelError("", "Fill all fields");
                return RedirectToAction("Index", "Customer", new { Id = comment.CustomerId });
            }
        }
    }
}