using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllConstraints : BaseModel
	{
      public VAllConstraints( ){ }
    

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Owner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ConstraintName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ConstraintType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TableName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String SearchCondition { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ROwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String RConstraintName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DeleteRule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Status { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Deferrable { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Deferred { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Validated { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Generated { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Bad { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Rely { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public DateTime? LastChange { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IndexOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IndexName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Invalid { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ViewRelated { get; set; }


	}

}
