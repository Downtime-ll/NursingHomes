using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace NursingHomes.Base.Domain
{
    /// <summary>
    /// 老人服务类
    /// </summary>
    public interface IOldManService : IApplicationService
    {
        /// <summary>
        /// 获取老人列表
        /// </summary>
        /// <returns></returns>
        Task<ListResultOutput<OldMan>> Get();

        /// <summary>
        /// 获取老人
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OldMan> Get(Guid id);

        /// <summary>
        /// 添加老人
        /// </summary>
        /// <param name="entity"></param>
        Task Add(OldMan entity);

        /// <summary>
        /// 修改老人
        /// </summary>
        /// <param name="entity"></param>
        Task Edit(OldMan entity);

        /// <summary>
        /// 删除老人
        /// </summary>
        /// <param name="id"></param>
        Task Delete(Guid id);

        /// <summary>
        /// 添加家属
        /// </summary>
        /// <param name="oldManId"></param>
        /// <param name="family"></param>
        Task AddRelation(Guid oldManId, Relation family);

        /// <summary>
        /// 修改家属
        /// </summary>
        /// <param name="oldManId"></param>
        /// <param name="family"></param>
        Task EditRelation(Guid oldManId, Relation family);

        /// <summary>
        /// 删除家属
        /// </summary>
        /// <param name="oldManId"></param>
        /// <param name="family"></param>
        Task DeleteRelation(Guid oldManId, Relation family);
    }
}
