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
	/// 实体类Questionnaire_Subject 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Questionnaire_Subject")]
	[Serializable]
	public partial class Questionnaire_Subject : Entity 
	{
		#region Model
		private int _Id;
		private string _Title;
		private int? _Score;
		private int? _Timelimit;
		private string _Remark;
		private int? _Sequence;
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
		/// 
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
		/// 
		/// </summary>
		public int? Score
		{
			get{ return _Score; }
			set
			{
				this.OnPropertyValueChange(_.Score,_Score,value);
				this._Score=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Timelimit
		{
			get{ return _Timelimit; }
			set
			{
				this.OnPropertyValueChange(_.Timelimit,_Timelimit,value);
				this._Timelimit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Sequence
		{
			get{ return _Sequence; }
			set
			{
				this.OnPropertyValueChange(_.Sequence,_Sequence,value);
				this._Sequence=value;
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
				_.Title,
				_.Score,
				_.Timelimit,
				_.Remark,
				_.Sequence};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._Title,
				this._Score,
				this._Timelimit,
				this._Remark,
				this._Sequence};
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
			public readonly static Field All = new Field("*","Questionnaire_Subject");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Questionnaire_Subject","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Title = new Field("Title","Questionnaire_Subject","Title");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Score = new Field("Score","Questionnaire_Subject","Score");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Timelimit = new Field("Timelimit","Questionnaire_Subject","Timelimit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Remark = new Field("Remark","Questionnaire_Subject","Remark");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sequence = new Field("Sequence","Questionnaire_Subject","Sequence");
		}
		#endregion


	}
}
