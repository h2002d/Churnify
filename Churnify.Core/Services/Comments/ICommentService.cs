using Churnify.Domain.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Churnify.Core.Services.Comments
{
    public interface ICommentService : IServiceBase<Comment>
    {
        Task<IReadOnlyList<Comment>> GetCustomerComments(int customerId);
    }
}
