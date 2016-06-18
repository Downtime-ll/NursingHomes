using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NursingHomes.Core.PagedList;

namespace NursingHomes.Base.Domain
{
    public interface INurserService
    {
        /// <summary>
        /// 护理人员列表
        /// </summary>
        /// <returns></returns>
        IPagedList<Nurser> Get();

        /// <summary>
        /// 获取护理人员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Nurser Get(Guid id);
        /// <summary>
        /// 添加护理人员
        /// </summary>
        /// <param name="entity"></param>
        void Add(Nurser entity);
        /// <summary>
        /// 修改护理人员
        /// </summary>
        /// <param name="entity"></param>
        void Edit(Nurser entity);
        /// <summary>
        /// 删除护理人员
        /// </summary>
        /// <param name="id"></param>
        void Delete(Guid id);
    }
}
