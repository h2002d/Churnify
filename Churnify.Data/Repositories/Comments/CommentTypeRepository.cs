using Churnify.Data.Data;
using Churnify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Churnify.Data.Repositories.Comments
{
    public class CommentTypeRepository : RepositoryBase<CommentType>, ICommentTypeRepository
    {
        public CommentTypeRepository(ApplicationDbContext context)
            : base(context)
        {
        }

    }
}
