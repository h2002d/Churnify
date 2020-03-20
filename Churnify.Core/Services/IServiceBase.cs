using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Core.Services
{
    public interface IServiceBase<TDto>
        where TDto : class, new()
    {
        Task<TDto> GetById(int id);

        Task<TDto> Add(TDto dto);

        Task Update(TDto dto);
    }
}
