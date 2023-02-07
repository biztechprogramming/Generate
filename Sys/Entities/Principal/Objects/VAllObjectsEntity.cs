using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllObjects : BaseModel
	{
      public VAllObjects( ){ }
    

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Owner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ObjectName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String SubobjectName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal ObjectId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? DataObjectId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ObjectType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public DateTime Created { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public DateTime LastDdlTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Timestamp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Status { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Temporary { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Generated { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Secondary { get; set; }


	}

}
