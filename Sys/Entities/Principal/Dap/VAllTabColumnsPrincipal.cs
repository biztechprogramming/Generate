using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Data.Base;
using Data.Entities;
 
namespace Data.Entities
{

	public partial class VAllTabColumnsDap : GenericBaseDap<VAllTabColumns>
	{
		public VAllTabColumnsDap()
		{
		}
		public VAllTabColumnsDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllTabColumnsDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllTabColumns Map(dynamic result){			
			return new VAllTabColumns
			{
				Owner=(String)result.OWNER, TableName=(String)result.TABLE_NAME, ColumnName=(String)result.COLUMN_NAME, DataType=(String)result.DATA_TYPE, DataTypeMod=(String)result.DATA_TYPE_MOD, DataTypeOwner=(String)result.DATA_TYPE_OWNER, DataLength=(Decimal)result.DATA_LENGTH, DataPrecision=(Decimal?)result.DATA_PRECISION, DataScale=(Decimal?)result.DATA_SCALE, Nullable=(String)result.NULLABLE, ColumnId=(Decimal?)result.COLUMN_ID, DefaultLength=(Decimal?)result.DEFAULT_LENGTH, DataDefault=(String)result.DATA_DEFAULT, NumDistinct=(Decimal?)result.NUM_DISTINCT, LowValue=(Byte[])result.LOW_VALUE, HighValue=(Byte[])result.HIGH_VALUE, Density=(Decimal?)result.DENSITY, NumNulls=(Decimal?)result.NUM_NULLS, NumBuckets=(Decimal?)result.NUM_BUCKETS, LastAnalyzed=(DateTime?)result.LAST_ANALYZED, SampleSize=(Decimal?)result.SAMPLE_SIZE, CharacterSetName=(String)result.CHARACTER_SET_NAME, CharColDeclLength=(Decimal?)result.CHAR_COL_DECL_LENGTH, GlobalStats=(String)result.GLOBAL_STATS, UserStats=(String)result.USER_STATS, AvgColLen=(Decimal?)result.AVG_COL_LEN, CharLength=(Decimal?)result.CHAR_LENGTH, CharUsed=(String)result.CHAR_USED, V80FmtImage=(String)result.V80_FMT_IMAGE, DataUpgraded=(String)result.DATA_UPGRADED, Histogram=(String)result.HISTOGRAM
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllTabColumns> All()
		{
			return Query<VAllTabColumns>(SqlSelectCommand, buffered: false);
		}

		public List<VAllTabColumns> GetTop(int count)
		{
			var queryResult = Query<VAllTabColumns>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllTabColumns> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_TAB_COLUMNS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
