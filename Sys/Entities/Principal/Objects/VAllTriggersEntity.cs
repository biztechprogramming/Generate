using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllTriggers : BaseModel
	{
      public VAllTriggers( ){ }
    

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Owner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TriggerName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TriggerType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TriggeringEvent { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TableOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String BaseObjectType { get; set; }

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
		public String ReferencingNames { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String WhenClause { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Status { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Description { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ActionType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TriggerBody { get; set; }


	}

}
