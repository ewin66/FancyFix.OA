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
	/// 实体类Valuable_Class 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Valuable_Class")]
	[Serializable]
	public partial class Valuable_Class : Entity 
	{
		#region Model
		private int _Id;
		private int? _ParId;
		private string _ClassName;
		private int? _Sequence;
		private int? _Depth;
		private int? _ChildNum;
		private string _ParPath;
		private bool? _BeLock;
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
		public int? ParId
		{
			get{ return _ParId; }
			set
			{
				this.OnPropertyValueChange(_.ParId,_ParId,value);
				this._ParId=value;
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
		public int? Sequence
		{
			get{ return _Sequence; }
			set
			{
				this.OnPropertyValueChange(_.Sequence,_Sequence,value);
				this._Sequence=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Depth
		{
			get{ return _Depth; }
			set
			{
				this.OnPropertyValueChange(_.Depth,_Depth,value);
				this._Depth=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChildNum
		{
			get{ return _ChildNum; }
			set
			{
				this.OnPropertyValueChange(_.ChildNum,_ChildNum,value);
				this._ChildNum=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParPath
		{
			get{ return _ParPath; }
			set
			{
				this.OnPropertyValueChange(_.ParPath,_ParPath,value);
				this._ParPath=value;
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
				_.ParId,
				_.ClassName,
				_.Sequence,
				_.Depth,
				_.ChildNum,
				_.ParPath,
				_.BeLock};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._ParId,
				this._ClassName,
				this._Sequence,
				this._Depth,
				this._ChildNum,
				this._ParPath,
				this._BeLock};
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
			public readonly static Field All = new Field("*","Valuable_Class");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Valuable_Class","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ParId = new Field("ParId","Valuable_Class","ParId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassName = new Field("ClassName","Valuable_Class","ClassName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sequence = new Field("Sequence","Valuable_Class","Sequence");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Depth = new Field("Depth","Valuable_Class","Depth");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ChildNum = new Field("ChildNum","Valuable_Class","ChildNum");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ParPath = new Field("ParPath","Valuable_Class","ParPath");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BeLock = new Field("BeLock","Valuable_Class","BeLock");
		}
		#endregion


	}
}
