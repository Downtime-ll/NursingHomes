using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NursingHomes.Core.PagedList;

namespace NursingHomes.Base.Domain
{
    /// <summary>
    /// 老人服务类
    /// </summary>
    public interface IOldManService
    {
        /// <summary>
        /// 获取老人列表
        /// </summary>
        /// <returns></returns>
        IPagedList<OldMan> Get();

        /// <summary>
        /// 获取老人
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        OldMan Get(Guid id);

        /// <summary>
        /// 添加老人
        /// </summary>
        /// <param name="entity"></param>
        void Add(OldMan entity);

        /// <summary>
        /// 修改老人
        /// </summary>
        /// <param name="entity"></param>
        void Edit(OldMan entity);

        /// <summary>
        /// 删除老人
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);

        /// <summary>
        /// 添加家属
        /// </summary>
        /// <param name="oldManId"></param>
        /// <param name="family"></param>
        void AddRelation(Guid oldManId, Relation family);

        /// <summary>
        /// 修改家属
        /// </summary>
        /// <param name="oldManId"></param>
        /// <param name="family"></param>
        void EditRelation(Guid oldManId, Relation family);

        /// <summary>
        /// 删除家属
        /// </summary>
        /// <param name="oldManId"></param>
        /// <param name="family"></param>
        void DeleteRelation(Guid oldManId, Relation family);




    }
}
