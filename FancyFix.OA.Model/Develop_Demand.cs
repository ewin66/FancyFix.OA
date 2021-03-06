﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace FancyFix.OA.Model
{
    /// <summary>
    /// 实体类Develop_Demand。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Develop_Demand")]
    [Serializable]
    public partial class Develop_Demand : Entity
    {
        #region Model
        private int _Id;
        private int _DeptId;
        private string _JoinPerson;
        private string _MissionNumber;
        private int _Type;
        private string _Content;
        private string _AffixAddress;
        private int _Status;
        private int? _ExecutorId;
        private int _CreateUserId;
        private DateTime _CreateTime;
        private DateTime? _UpdateTime;
        private DateTime? _ExecutorTime;
        private DateTime? _CompleteTime;
        private DateTime _EstimateCompleteTime;

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange("Id");
                this._Id = value;
            }
        }
        /// <summary>
        /// 部门Id
        /// </summary>
        public int DeptId
        {
            get { return _DeptId; }
            set
            {
                this.OnPropertyValueChange("DeptId");
                this._DeptId = value;
            }
        }
        /// <summary>
        /// 需求对接人
        /// </summary>
        public string JoinPerson
        {
            get { return _JoinPerson; }
            set
            {
                this.OnPropertyValueChange("JoinPerson");
                this._JoinPerson = value;
            }
        }
        /// <summary>
        /// 任务编号
        /// </summary>
        public string MissionNumber
        {
            get { return _MissionNumber; }
            set
            {
                this.OnPropertyValueChange("MissionNumber");
                this._MissionNumber = value;
            }
        }
        /// <summary>
        /// 需求类型
        /// </summary>
        public int Type
        {
            get { return _Type; }
            set
            {
                this.OnPropertyValueChange("Type");
                this._Type = value;
            }
        }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return _Content; }
            set
            {
                this.OnPropertyValueChange("Content");
                this._Content = value;
            }
        }
        /// <summary>
        /// 附件地址
        /// </summary>
        public string AffixAddress
        {
            get { return _AffixAddress; }
            set
            {
                this.OnPropertyValueChange("AffixAddress");
                this._AffixAddress = value;
            }
        }
        /// <summary>
        /// 状态 1：未完成 2：已完成
        /// </summary>
        public int Status
        {
            get { return _Status; }
            set
            {
                this.OnPropertyValueChange("Status");
                this._Status = value;
            }
        }
        /// <summary>
        /// 执行人Id
        /// </summary>
        public int? ExecutorId
        {
            get { return _ExecutorId; }
            set
            {
                this.OnPropertyValueChange("ExecutorId");
                this._ExecutorId = value;
            }
        }
        /// <summary>
        /// 创建人Id
        /// </summary>
        public int CreateUserId
        {
            get { return _CreateUserId; }
            set
            {
                this.OnPropertyValueChange("CreateUserId");
                this._CreateUserId = value;
            }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange("CreateTime");
                this._CreateTime = value;
            }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return _UpdateTime; }
            set
            {
                this.OnPropertyValueChange("UpdateTime");
                this._UpdateTime = value;
            }
        }
        /// <summary>
        /// 执行时间
        /// </summary>
        public DateTime? ExecutorTime
        {
            get { return _ExecutorTime; }
            set
            {
                this.OnPropertyValueChange("ExecutorTime");
                this._ExecutorTime = value;
            }
        }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime? CompleteTime
        {
            get { return _CompleteTime; }
            set
            {
                this.OnPropertyValueChange("CompleteTime");
                this._CompleteTime = value;
            }
        }
        /// <summary>
        /// 预计完成时间
        /// </summary>
        public DateTime EstimateCompleteTime
        {
            get { return _EstimateCompleteTime; }
            set
            {
                this.OnPropertyValueChange("EstimateCompleteTime");
                this._EstimateCompleteTime = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.Id,
            };
        }
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.Id;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Id,
                _.DeptId,
                _.JoinPerson,
                _.MissionNumber,
                _.Type,
                _.Content,
                _.AffixAddress,
                _.Status,
                _.ExecutorId,
                _.CreateUserId,
                _.CreateTime,
                _.UpdateTime,
                _.ExecutorTime,
                _.CompleteTime,
                _.EstimateCompleteTime,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._DeptId,
                this._JoinPerson,
                this._MissionNumber,
                this._Type,
                this._Content,
                this._AffixAddress,
                this._Status,
                this._ExecutorId,
                this._CreateUserId,
                this._CreateTime,
                this._UpdateTime,
                this._ExecutorTime,
                this._CompleteTime,
                this._EstimateCompleteTime,
            };
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "Develop_Demand");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "Develop_Demand", "");
            /// <summary>
			/// 部门Id
			/// </summary>
			public readonly static Field DeptId = new Field("DeptId", "Develop_Demand", "部门Id");
            /// <summary>
			/// 需求对接人
			/// </summary>
			public readonly static Field JoinPerson = new Field("JoinPerson", "Develop_Demand", "需求对接人");
            /// <summary>
			/// 任务编号
			/// </summary>
			public readonly static Field MissionNumber = new Field("MissionNumber", "Develop_Demand", "任务编号");
            /// <summary>
			/// 需求类型
			/// </summary>
			public readonly static Field Type = new Field("Type", "Develop_Demand", "需求类型");
            /// <summary>
			/// 内容
			/// </summary>
			public readonly static Field Content = new Field("Content", "Develop_Demand", "内容");
            /// <summary>
			/// 附件地址
			/// </summary>
			public readonly static Field AffixAddress = new Field("AffixAddress", "Develop_Demand", "附件地址");
            /// <summary>
			/// 状态 1：未完成 2：已完成
			/// </summary>
			public readonly static Field Status = new Field("Status", "Develop_Demand", "状态 1：未完成 2：已完成");
            /// <summary>
			/// 执行人Id
			/// </summary>
			public readonly static Field ExecutorId = new Field("ExecutorId", "Develop_Demand", "执行人Id");
            /// <summary>
			/// 创建人Id
			/// </summary>
			public readonly static Field CreateUserId = new Field("CreateUserId", "Develop_Demand", "创建人Id");
            /// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime", "Develop_Demand", "创建时间");
            /// <summary>
			/// 修改时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime", "Develop_Demand", "修改时间");
            /// <summary>
			/// 执行时间
			/// </summary>
			public readonly static Field ExecutorTime = new Field("ExecutorTime", "Develop_Demand", "执行时间");
            /// <summary>
			/// 完成时间
			/// </summary>
			public readonly static Field CompleteTime = new Field("CompleteTime", "Develop_Demand", "完成时间");
            /// <summary>
			/// 预计完成时间
			/// </summary>
			public readonly static Field EstimateCompleteTime = new Field("EstimateCompleteTime", "Develop_Demand", "预计完成时间");
        }
        #endregion
    }
}