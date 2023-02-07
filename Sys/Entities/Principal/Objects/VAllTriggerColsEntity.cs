using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllTriggerCols : BaseModel
	{
      public VAllTriggerCols( ){ }
    

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TriggerOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TriggerName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TableOwner { get; set; }

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
		public String ColumnList { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ColumnUsage { get; set; }


	}

}
