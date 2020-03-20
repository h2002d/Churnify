using Churnify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Data.Repositories.Comments
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<IReadOnlyList<Comment>> GetCustomerComments(int customerId);
    }
}
