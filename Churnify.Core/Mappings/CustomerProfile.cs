using AutoMapper;
using Churnify.Domain.Entities;
using Dto = Churnify.Domain.Dto;

namespace Churnify.Core.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Dto.Customer, Churnify.Domain.Entities.Customer>();
            CreateMap<Churnify.Domain.Entities.Customer, Dto.Customer>();
        }
    }
}
