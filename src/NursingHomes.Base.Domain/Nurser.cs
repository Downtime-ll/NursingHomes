using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomes.Base.Domain
{
    /// <summary>
    /// 护工
    /// </summary>
    public class Nurser
    {
        public Guid Id { get; set; }

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
