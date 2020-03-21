using AutoMapper;
using Churnify.Data.Repositories.Comments;
using Churnify.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Core.Services.Comments
{
    public class CommentService : ServiceBase<Churnify.Domain.Entities.Comment, Comment>, ICommentService
    {
        private readonly ICommentRepository _customerRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository customerRepository, IMapper mapper)
            : base(customerRepository, mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Comment>> GetCustomerComments(int customerId)
        {
            var comments = await _customerRepository.GetCustomerComments(customerId);
            return _mapper.Map<IReadOnlyList<Comment>>(comments);
        } 
    }
}
