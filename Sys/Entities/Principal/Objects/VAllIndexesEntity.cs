using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllIndexes : BaseModel
	{
      public VAllIndexes( ){ }
    

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Owner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IndexName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IndexType { get; set; }

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
		public String TableType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Uniqueness { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Compression { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? PrefixLength { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String TablespaceName { get; set; }

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
		public Decimal? PctThreshold { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? IncludeColumn { get; set; }

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
		public Decimal? PctFree { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Logging { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? Blevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? LeafBlocks { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? DistinctKeys { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? AvgLeafBlocksPerKey { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? AvgDataBlocksPerKey { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? ClusteringFactor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Status { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NumRows { get; set; }

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
		public String Partitioned { get; set; }

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

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String BufferPool { get; set; }

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
		public Decimal? PctDirectAccess { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ItypOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String ItypName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Parameters { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String GlobalStats { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DomidxStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DomidxOpstatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String FuncidxStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String JoinIndex { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String IotRedundantPkeyElim { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Dropped { get; set; }


	}

}
