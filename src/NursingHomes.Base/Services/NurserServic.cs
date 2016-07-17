using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using NursingHomes.Base.Domain;
using NursingHomes.Base.Domain.Dtos;

namespace NursingHomes.Base.Services
{
    public class NurserService : ApplicationService, INurserService
    {
        private readonly IRepository<Nurser,Guid> _nurseRepository;

        public NurserService(IRepository<Nurser,Guid> nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }

        public async Task<ListResultOutput<NurserDto>> Get()
        {
            var list = await _nurseRepository.GetAllListAsync();
            return  new ListResultOutput<NurserDto>(
                ObjectMapper.Map<List<NurserDto>>(list)
            );
        }

        public Task<NurserDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Nurser entity)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Nurser entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
