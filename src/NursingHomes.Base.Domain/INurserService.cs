using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NursingHomes.Base.Domain.Dtos;

namespace NursingHomes.Base.Domain
{
    public interface INurserService : IApplicationService
    {
        /// <summary>
        /// 护理人员列表
        /// </summary>
        /// <returns></returns>
        Task<ListResultOutput<NurserDto>> Get();

        /// <summary>
        /// 获取护理人员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<NurserDto> Get(Guid id);
        /// <summary>
        /// 添加护理人员
        /// </summary>
        /// <param name="entity"></param>
        Task Add(Nurser entity);
        /// <summary>
        /// 修改护理人员
        /// </summary>
        /// <param name="entity"></param>
        Task Edit(Nurser entity);
        /// <summary>
        /// 删除护理人员
        /// </summary>
        /// <param name="id"></param>
        Task Delete(Guid id);
    }
}
