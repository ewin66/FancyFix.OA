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
	/// 实体类Product_Pattern 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Product_Pattern")]
	[Serializable]
	public partial class Product_Pattern : Entity 
	{
		#region Model
		private int _Id;
		private string _PatternName;
		private string _Pics;
		private string _FirstPic;
		private int? _AdminId;
		private DateTime? _AddTime;
		private bool? _IsShow;
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
		public string PatternName
		{
			get{ return _PatternName; }
			set
			{
				this.OnPropertyValueChange(_.PatternName,_PatternName,value);
				this._PatternName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pics
		{
			get{ return _Pics; }
			set
			{
				this.OnPropertyValueChange(_.Pics,_Pics,value);
				this._Pics=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FirstPic
		{
			get{ return _FirstPic; }
			set
			{
				this.OnPropertyValueChange(_.FirstPic,_FirstPic,value);
				this._FirstPic=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AdminId
		{
			get{ return _AdminId; }
			set
			{
				this.OnPropertyValueChange(_.AdminId,_AdminId,value);
				this._AdminId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			get{ return _AddTime; }
			set
			{
				this.OnPropertyValueChange(_.AddTime,_AddTime,value);
				this._AddTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsShow
		{
			get{ return _IsShow; }
			set
			{
				this.OnPropertyValueChange(_.IsShow,_IsShow,value);
				this._IsShow=value;
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
				_.PatternName,
				_.Pics,
				_.FirstPic,
				_.AdminId,
				_.AddTime,
				_.IsShow};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._PatternName,
				this._Pics,
				this._FirstPic,
				this._AdminId,
				this._AddTime,
				this._IsShow};
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
			public readonly static Field All = new Field("*","Product_Pattern");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Product_Pattern","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field PatternName = new Field("PatternName","Product_Pattern","PatternName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Pics = new Field("Pics","Product_Pattern","Pics");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field FirstPic = new Field("FirstPic","Product_Pattern","FirstPic");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AdminId = new Field("AdminId","Product_Pattern","AdminId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AddTime = new Field("AddTime","Product_Pattern","AddTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsShow = new Field("IsShow","Product_Pattern","IsShow");
		}
		#endregion


	}
}

