using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllTables : BaseModel
	{
      public VAllTables( ){ }
    

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
		public String TablespaceName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ClusterName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IotName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Status { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? PctFree { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? PctUsed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? IniTrans { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? MaxTrans { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? InitialExtent { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NextExtent { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? MinExtents { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? MaxExtents { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? PctIncrease { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? Freelists { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? FreelistGroups { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Logging { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String BackedUp { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NumRows { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? Blocks { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? EmptyBlocks { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? AvgSpace { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? ChainCnt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? AvgRowLen { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? AvgSpaceFreelistBlocks { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NumFreelistBlocks { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Degree { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Instances { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Cache { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TableLock { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? SampleSize { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public DateTime? LastAnalyzed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Partitioned { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IotType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Temporary { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Secondary { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Nested { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String BufferPool { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String RowMovement { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String GlobalStats { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String UserStats { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Duration { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String SkipCorrupt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Monitoring { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ClusterOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Dependencies { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Compression { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Dropped { get; set; }


	}

}
