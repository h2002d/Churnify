using AutoMapper;
using Churnify.Domain.Models;
using Dto = Churnify.Domain.Dto;

namespace Churnify.Web.App.Mappings
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<Dto.Comment, Comment>();
            CreateMap<Comment, Dto.Comment>();
            CreateMap<CommentType, Dto.CommentType>();
            CreateMap<Dto.CommentType, CommentType>();
        }
    }
}
