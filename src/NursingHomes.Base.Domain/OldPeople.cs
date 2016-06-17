using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NursingHomes.Base.Domain
{
    public class OldPeople
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 房间号
        /// </summary>
        public string RoomNo { get; set; }

        /// <summary>
        /// 医疗历史
        /// </summary>
        public string MedicalHistory { get; set; }

        /// <summary>
        /// 家属
        /// </summary>
        public ICollection<Family> Families { get; set; }


    }

    /// <summary>
    /// 家属
    /// </summary>
    public class Family
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 家属Id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 关系
        /// </summary>
        public RelationType RelationType { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 工作信息
        /// </summary>
        public string WorkInfo { get; set; }
    }

    public enum Sex
    {
        Men,
        Women
    }

    public enum RelationType
    {
        Parent,
        BrotherOrSister,
        Children,
        Friend,
        Other
    }
}
