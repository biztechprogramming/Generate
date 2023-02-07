using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Data.Base;
 
namespace Data.Entities
{

	public partial class VAllTabColumns : BaseModel
	{
      public VAllTabColumns( ){ }
    

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
		public String DataType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DataTypeMod { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DataTypeOwner { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal DataLength { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? DataPrecision { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? DataScale { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Nullable { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? ColumnId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? DefaultLength { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DataDefault { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NumDistinct { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Byte[] LowValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Byte[] HighValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? Density { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NumNulls { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? NumBuckets { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public DateTime? LastAnalyzed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? SampleSize { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String CharacterSetName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? CharColDeclLength { get; set; }

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
		public Decimal? AvgColLen { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public Decimal? CharLength { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String CharUsed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String V80FmtImage { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String DataUpgraded { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "")]
		public String Histogram { get; set; }


	}

}
