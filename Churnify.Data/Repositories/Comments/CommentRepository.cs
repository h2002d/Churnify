using Churnify.Data.Data;
using Churnify.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Data.Repositories.Comments
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<IReadOnlyList<Comment>> GetCustomerComments(int customerId)
        {
            return await context.Comments.Where(x => x.CustomerId == customerId).ToListAsync();
        }
    }
}
