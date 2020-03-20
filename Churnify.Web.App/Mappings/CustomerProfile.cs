using AutoMapper;
using Dto=Churnify.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Churnify.Domain.Models;

namespace Churnify.Web.App.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Dto.Customer, Customer>();
            CreateMap<Customer, Dto.Customer>();
        }
    }
}
