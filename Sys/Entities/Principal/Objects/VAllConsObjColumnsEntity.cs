using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllConsObjColumns : BaseModel
	{
      public VAllConsObjColumns( ){ }
    

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Owner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TableName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ColumnName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ConsTypeOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ConsTypeName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ConsTypeOnly { get; set; }


	}

}
