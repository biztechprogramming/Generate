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

	public partial class VAllTablesDap : GenericBaseDap<VAllTables>
	{
		public VAllTablesDap()
		{
		}
		public VAllTablesDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllTablesDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllTables Map(dynamic result){			
			return new VAllTables
			{
				Owner=(String)result.OWNER, TableName=(String)result.TABLE_NAME, TablespaceName=(String)result.TABLESPACE_NAME, ClusterName=(String)result.CLUSTER_NAME, IotName=(String)result.IOT_NAME, Status=(String)result.STATUS, PctFree=(Decimal?)result.PCT_FREE, PctUsed=(Decimal?)result.PCT_USED, IniTrans=(Decimal?)result.INI_TRANS, MaxTrans=(Decimal?)result.MAX_TRANS, InitialExtent=(Decimal?)result.INITIAL_EXTENT, NextExtent=(Decimal?)result.NEXT_EXTENT, MinExtents=(Decimal?)result.MIN_EXTENTS, MaxExtents=(Decimal?)result.MAX_EXTENTS, PctIncrease=(Decimal?)result.PCT_INCREASE, Freelists=(Decimal?)result.FREELISTS, FreelistGroups=(Decimal?)result.FREELIST_GROUPS, Logging=(String)result.LOGGING, BackedUp=(String)result.BACKED_UP, NumRows=(Decimal?)result.NUM_ROWS, Blocks=(Decimal?)result.BLOCKS, EmptyBlocks=(Decimal?)result.EMPTY_BLOCKS, AvgSpace=(Decimal?)result.AVG_SPACE, ChainCnt=(Decimal?)result.CHAIN_CNT, AvgRowLen=(Decimal?)result.AVG_ROW_LEN, AvgSpaceFreelistBlocks=(Decimal?)result.AVG_SPACE_FREELIST_BLOCKS, NumFreelistBlocks=(Decimal?)result.NUM_FREELIST_BLOCKS, Degree=(String)result.DEGREE, Instances=(String)result.INSTANCES, Cache=(String)result.CACHE, TableLock=(String)result.TABLE_LOCK, SampleSize=(Decimal?)result.SAMPLE_SIZE, LastAnalyzed=(DateTime?)result.LAST_ANALYZED, Partitioned=(String)result.PARTITIONED, IotType=(String)result.IOT_TYPE, Temporary=(String)result.TEMPORARY, Secondary=(String)result.SECONDARY, Nested=(String)result.NESTED, BufferPool=(String)result.BUFFER_POOL, RowMovement=(String)result.ROW_MOVEMENT, GlobalStats=(String)result.GLOBAL_STATS, UserStats=(String)result.USER_STATS, Duration=(String)result.DURATION, SkipCorrupt=(String)result.SKIP_CORRUPT, Monitoring=(String)result.MONITORING, ClusterOwner=(String)result.CLUSTER_OWNER, Dependencies=(String)result.DEPENDENCIES, Compression=(String)result.COMPRESSION, Dropped=(String)result.DROPPED
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllTables> All()
		{
			return Query<VAllTables>(SqlSelectCommand, buffered: false);
		}

		public List<VAllTables> GetTop(int count)
		{
			var queryResult = Query<VAllTables>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllTables> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_TABLES";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
