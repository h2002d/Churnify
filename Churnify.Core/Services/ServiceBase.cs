using AutoMapper;
using Churnify.Domain.Entities;
using Churnify.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Churnify.Core.Services
{
    public class ServiceBase<TEntity, TDto> : IServiceBase<TDto>
        where TEntity : BaseEntity, new()
        where TDto : class, new()
    {
        private readonly IRepository<TEntity> _commonRepository;
        private readonly IMapper _mapper;

        public ServiceBase(IRepository<TEntity> commonRepository, IMapper mapper)
        {
            _commonRepository = commonRepository;
            _mapper = mapper;
        }

        public async Task<TDto> Add(TDto dto)
        {
            if (dto == null) return null;

            var recordToAdd = _mapper.Map<TEntity>(dto);
            return _mapper.Map<TDto>(await _commonRepository.Create(recordToAdd));
        }

        public async Task<IReadOnlyList<TDto>> All()
            => _mapper.Map<IReadOnlyList<TDto>>(await _commonRepository.All());

        public async Task<TDto> GetById(int id)
            => _mapper.Map<TDto>(await _commonRepository.GetById(id));

        public async Task Update(TDto dto)
        {
            _commonRepository.Update(_mapper.Map<TEntity>(dto));
        }
    }
}
