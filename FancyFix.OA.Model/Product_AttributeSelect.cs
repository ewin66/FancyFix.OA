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
	/// 实体类Product_AttributeSelect 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("Product_AttributeSelect")]
	[Serializable]
	public partial class Product_AttributeSelect : Entity 
	{
		#region Model
		private int _Id;
		private int? _AttributeId;
		private string _ItemName;
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
		public int? AttributeId
		{
			get{ return _AttributeId; }
			set
			{
				this.OnPropertyValueChange(_.AttributeId,_AttributeId,value);
				this._AttributeId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemName
		{
			get{ return _ItemName; }
			set
			{
				this.OnPropertyValueChange(_.ItemName,_ItemName,value);
				this._ItemName=value;
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
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Id,
				_.AttributeId,
				_.ItemName,
				_.Sequence};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Id,
				this._AttributeId,
				this._ItemName,
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
			public readonly static Field All = new Field("*","Product_AttributeSelect");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id","Product_AttributeSelect","Id");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field AttributeId = new Field("AttributeId","Product_AttributeSelect","AttributeId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ItemName = new Field("ItemName","Product_AttributeSelect","ItemName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Sequence = new Field("Sequence","Product_AttributeSelect","Sequence");
		}
		#endregion


	}
}

