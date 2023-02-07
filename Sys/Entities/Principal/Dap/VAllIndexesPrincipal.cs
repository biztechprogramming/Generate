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

	public partial class VAllIndexesDap : GenericBaseDap<VAllIndexes>
	{
		public VAllIndexesDap()
		{
		}
		public VAllIndexesDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllIndexesDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllIndexes Map(dynamic result){			
			return new VAllIndexes
			{
				Owner=(String)result.OWNER, IndexName=(String)result.INDEX_NAME, IndexType=(String)result.INDEX_TYPE, TableOwner=(String)result.TABLE_OWNER, TableName=(String)result.TABLE_NAME, TableType=(String)result.TABLE_TYPE, Uniqueness=(String)result.UNIQUENESS, Compression=(String)result.COMPRESSION, PrefixLength=(Decimal?)result.PREFIX_LENGTH, TablespaceName=(String)result.TABLESPACE_NAME, IniTrans=(Decimal?)result.INI_TRANS, MaxTrans=(Decimal?)result.MAX_TRANS, InitialExtent=(Decimal?)result.INITIAL_EXTENT, NextExtent=(Decimal?)result.NEXT_EXTENT, MinExtents=(Decimal?)result.MIN_EXTENTS, MaxExtents=(Decimal?)result.MAX_EXTENTS, PctIncrease=(Decimal?)result.PCT_INCREASE, PctThreshold=(Decimal?)result.PCT_THRESHOLD, IncludeColumn=(Decimal?)result.INCLUDE_COLUMN, Freelists=(Decimal?)result.FREELISTS, FreelistGroups=(Decimal?)result.FREELIST_GROUPS, PctFree=(Decimal?)result.PCT_FREE, Logging=(String)result.LOGGING, Blevel=(Decimal?)result.BLEVEL, LeafBlocks=(Decimal?)result.LEAF_BLOCKS, DistinctKeys=(Decimal?)result.DISTINCT_KEYS, AvgLeafBlocksPerKey=(Decimal?)result.AVG_LEAF_BLOCKS_PER_KEY, AvgDataBlocksPerKey=(Decimal?)result.AVG_DATA_BLOCKS_PER_KEY, ClusteringFactor=(Decimal?)result.CLUSTERING_FACTOR, Status=(String)result.STATUS, NumRows=(Decimal?)result.NUM_ROWS, SampleSize=(Decimal?)result.SAMPLE_SIZE, LastAnalyzed=(DateTime?)result.LAST_ANALYZED, Degree=(String)result.DEGREE, Instances=(String)result.INSTANCES, Partitioned=(String)result.PARTITIONED, Temporary=(String)result.TEMPORARY, Generated=(String)result.GENERATED, Secondary=(String)result.SECONDARY, BufferPool=(String)result.BUFFER_POOL, UserStats=(String)result.USER_STATS, Duration=(String)result.DURATION, PctDirectAccess=(Decimal?)result.PCT_DIRECT_ACCESS, ItypOwner=(String)result.ITYP_OWNER, ItypName=(String)result.ITYP_NAME, Parameters=(String)result.PARAMETERS, GlobalStats=(String)result.GLOBAL_STATS, DomidxStatus=(String)result.DOMIDX_STATUS, DomidxOpstatus=(String)result.DOMIDX_OPSTATUS, FuncidxStatus=(String)result.FUNCIDX_STATUS, JoinIndex=(String)result.JOIN_INDEX, IotRedundantPkeyElim=(String)result.IOT_REDUNDANT_PKEY_ELIM, Dropped=(String)result.DROPPED
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllIndexes> All()
		{
			return Query<VAllIndexes>(SqlSelectCommand, buffered: false);
		}

		public List<VAllIndexes> GetTop(int count)
		{
			var queryResult = Query<VAllIndexes>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllIndexes> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_INDEXES";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
