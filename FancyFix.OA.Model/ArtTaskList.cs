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
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace FancyFix.OA.Model
{

	/// <summary>
	/// 实体类ArtTaskList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("ArtTaskList")]
	[Serializable]
	public partial class ArtTaskList : Entity 
	{
		#region Model
		private int _Id;
		private string _Number;
		private string _Title;
		private string _Content;
		private string _Phone;
		private DateTime? _DueDate;
		private int? _SubmitterId;
		private DateTime? _SubmittedDate;
		private int? _DesignerId;
		private DateTime? _EstimatedStartDate;
		private DateTime? _EstimatedEndDate;
		private DateTime? _CompletionDate;
		private int? _AMPM;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get{ return _Id; }
			set
			{
				this.OnPropertyValueChange(_.Id,_Id,value);
				this._Id=value;
			}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Number
		{
			get{ return _Number; }
			set
			{
				this.OnPropertyValueChange(_.Number,_Number,value);
				this._Number=value;
			}
		}
		/// <summary>
		/// 任务标题
		/// </summary>
		public string Title
		{
			get{ return _Title; }
			set
			{
				this.OnPropertyValueChange(_.Title,_Title,value);
				this._Title=value;
			}
		}
		/// <summary>
		/// 任务详细
		/// </summary>
		public string Content
		{
			get{ return _Content; }
			set
			{
				this.OnPropertyValueChange(_.Content,_Content,value);
				this._Content=value;
			}
		}
		/// <summary>
		/// 事业部联系号码，用于沟通联系
		/// </summary>
		public string Phone
		{
			get{ return _Phone; }
			set
			{
				this.OnPropertyValueChange(_.Phone,_Phone,value);
				this._Phone=value;
			}
		}
		/// <summary>
		/// 截止日期
		/// </summary>
		public DateTime? DueDate
		{
			get{ return _DueDate; }
			set
			{
				this.OnPropertyValueChange(_.DueDate,_DueDate,value);
				this._DueDate=value;
			}
		}
		/// <summary>
		/// 任务提交人
		/// </summary>
		public int? SubmitterId
		{
			get{ return _SubmitterId; }
			set
			{
				this.OnPropertyValueChange(_.SubmitterId,_SubmitterId,value);
				this._SubmitterId=value;
			}
		}
		/// <summary>
		/// 提交任务日期
		/// </summary>
		public DateTime? SubmittedDate
		{
			get{ return _SubmittedDate; }
			set
			{
				this.OnPropertyValueChange(_.SubmittedDate,_SubmittedDate,value);
				this._SubmittedDate=value;
			}
		}
		/// <summary>
		/// 设计师
		/// </summary>
		public int? DesignerId
		{
			get{ return _DesignerId; }
			set
			{
				this.OnPropertyValueChange(_.DesignerId,_DesignerId,value);
				this._DesignerId=value;
			}
		}
		/// <summary>
		/// 预计开始日期
		/// </summary>
		public DateTime? EstimatedStartDate
		{
			get{ return _EstimatedStartDate; }
			set
			{
				this.OnPropertyValueChange(_.EstimatedStartDate,_EstimatedStartDate,value);
				this._EstimatedStartDate=value;
			}
		}
		/// <summary>
		/// 预计结束日期
		/// </summary>
		public DateTime? EstimatedEndDate
		{
			get{ return _EstimatedEndDate; }
			set
			{
				this.OnPropertyValueChange(_.EstimatedEndDate,_EstimatedEndDate,value);
				this._EstimatedEndDate=value;
			}
		}
		/// <summary>
		/// 实际完成日期
		/// </summary>
		public DateTime? CompletionDate
		{
			get{ return _CompletionDate; }
			set
			{
				this.OnPropertyValueChange(_.CompletionDate,_CompletionDate,value);
				this._CompletionDate=value;
			}
		}
		/// <summary>
		/// 上下午
		/// </summary>
		public int? AMPM
		{
			get{ return _AMPM; }
			set
			{
				this.OnPropertyValueChange(_.AMPM,_AMPM,value);
				this._AMPM=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.Id;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Id};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.Number,
				_.Title,
				_.Content,
				_.Phone,
				_.DueDate,
				_.SubmitterId,
				_.SubmittedDate,
				_.DesignerId,
				_.EstimatedStartDate,
				_.EstimatedEndDate,
				_.CompletionDate,
				_.AMPM};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._Number,
				this._Title,
				this._Content,
				this._Phone,
				this._DueDate,
				this._SubmitterId,
				this._SubmittedDate,
				this._DesignerId,
				this._EstimatedStartDate,
				this._EstimatedEndDate,
				this._CompletionDate,
				this._AMPM};
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
			public readonly static Field All = new Field("*","ArtTaskList");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","ArtTaskList","Id");
			/// <summary>
			/// 编号
			/// </summary>
			public readonly static Field Number = new Field("Number","ArtTaskList","编号");
			/// <summary>
			/// 任务标题
			/// </summary>
			public readonly static Field Title = new Field("Title","ArtTaskList","任务标题");
			/// <summary>
			/// 任务详细
			/// </summary>
			public readonly static Field Content = new Field("Content","ArtTaskList","任务详细");
			/// <summary>
			/// 事业部联系号码，用于沟通联系
			/// </summary>
			public readonly static Field Phone = new Field("Phone","ArtTaskList","事业部联系号码，用于沟通联系");
			/// <summary>
			/// 截止日期
			/// </summary>
			public readonly static Field DueDate = new Field("DueDate","ArtTaskList","截止日期");
			/// <summary>
			/// 任务提交人
			/// </summary>
			public readonly static Field SubmitterId = new Field("SubmitterId","ArtTaskList","任务提交人");
			/// <summary>
			/// 提交任务日期
			/// </summary>
			public readonly static Field SubmittedDate = new Field("SubmittedDate","ArtTaskList","提交任务日期");
			/// <summary>
			/// 设计师
			/// </summary>
			public readonly static Field DesignerId = new Field("DesignerId","ArtTaskList","设计师");
			/// <summary>
			/// 预计开始日期
			/// </summary>
			public readonly static Field EstimatedStartDate = new Field("EstimatedStartDate","ArtTaskList","预计开始日期");
			/// <summary>
			/// 预计结束日期
			/// </summary>
			public readonly static Field EstimatedEndDate = new Field("EstimatedEndDate","ArtTaskList","预计结束日期");
			/// <summary>
			/// 实际完成日期
			/// </summary>
			public readonly static Field CompletionDate = new Field("CompletionDate","ArtTaskList","实际完成日期");
			/// <summary>
			/// 上下午
			/// </summary>
			public readonly static Field AMPM = new Field("AMPM","ArtTaskList","上下午");
		}
		#endregion


	}
}

