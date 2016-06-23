using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace NursingHomes.Base.Domain
{
    /// <summary>
    /// 护工
    /// </summary>
    public class Nurser : AuditedEntity<Guid>
    {

        public string Name { get; set; }

        /// <summary>
        /// 护工No
        /// </summary>
        public string NurserNo { get; set; }

        /// <summary>
        /// 工作年份
        /// </summary>
        public int WorkYear { get; set; }

        /// <summary>
        /// 护工备注
        /// </summary>
        public string Remark { get; set; }
    }
}
