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
	/// 实体类Product_CodeSequence 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Product_CodeSequence")]
	[Serializable]
	public partial class Product_CodeSequence : Entity 
	{
		#region Model
		private int _Id;
		private int? _ClassId;
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
			public readonly static Field All = new Field("*","Product_CodeSequence");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Product_CodeSequence","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ClassId = new Field("ClassId","Product_CodeSequence","ClassId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sequence = new Field("Sequence","Product_CodeSequence","Sequence");
		}
		#endregion


	}
}
