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
	/// 实体类Valuable_List 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Valuable_List")]
	[Serializable]
	public partial class Valuable_List : Entity 
	{
		#region Model
		private int _Id;
		private int? _ClassId;
		private string _ClassName;
		private string _Content;
		private int? _Score;
		private bool? _BeLock;
		private int? _UserId;
		private DateTime? _CreateTime;
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
		public int? ClassId
		{
			get{ return _ClassId; }
			set
			{
				this.OnPropertyValueChange(_.ClassId,_ClassId,value);
				this._ClassId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClassName
		{
			get{ return _ClassName; }
			set
			{
				this.OnPropertyValueChange(_.ClassName,_ClassName,value);
				this._ClassName=value;
			}
		}
		/// <summary>
		/// 
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
		public bool? BeLock
		{
			get{ return _BeLock; }
			set
			{
				this.OnPropertyValueChange(_.BeLock,_BeLock,value);
				this._BeLock=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserId
		{
			get{ return _UserId; }
			set
			{
				this.OnPropertyValueChange(_.UserId,_UserId,value);
				this._UserId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
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
				_.ClassId,
				_.ClassName,
				_.Content,
				_.Score,
				_.BeLock,
				_.UserId,
				_.CreateTime,
				_.Sequence};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._ClassId,
				this._ClassName,
				this._Content,
				this._Score,
				this._BeLock,
				this._UserId,
				this._CreateTime,
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
			public readonly static Field All = new Field("*","Valuable_List");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Valuable_List","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassId = new Field("ClassId","Valuable_List","ClassId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","Valuable_List","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Content = new Field("Content","Valuable_List","Content");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Score = new Field("Score","Valuable_List","Score");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BeLock = new Field("BeLock","Valuable_List","BeLock");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UserId = new Field("UserId","Valuable_List","UserId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","Valuable_List","CreateTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sequence = new Field("Sequence","Valuable_List","Sequence");
		}
		#endregion


	}
}
