using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace NursingHomes.Base.Domain.Dtos
{
    [AutoMapFrom(typeof(Nurser))]
    public class NurserDto:EntityDto
    {
    }
}
