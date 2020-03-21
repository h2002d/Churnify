using AutoMapper;
using Churnify.Data.Repositories.Comments;


namespace Churnify.Core.Services.Comments
{
    public class CommentTypeService : ServiceBase<Churnify.Domain.Entities.CommentType, Domain.Dto.CommentType>, ICommentTypeService
    {
        public CommentTypeService(ICommentTypeRepository commonRepository, IMapper mapper) :
            base(commonRepository, mapper)
        {
        }
    }
}
