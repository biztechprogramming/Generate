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

	public partial class VAllTriggerColsDap : GenericBaseDap<VAllTriggerCols>
	{
		public VAllTriggerColsDap()
		{
		}
		public VAllTriggerColsDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllTriggerColsDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllTriggerCols Map(dynamic result){			
			return new VAllTriggerCols
			{
				TriggerOwner=(String)result.TRIGGER_OWNER, TriggerName=(String)result.TRIGGER_NAME, TableOwner=(String)result.TABLE_OWNER, TableName=(String)result.TABLE_NAME, ColumnName=(String)result.COLUMN_NAME, ColumnList=(String)result.COLUMN_LIST, ColumnUsage=(String)result.COLUMN_USAGE
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllTriggerCols> All()
		{
			return Query<VAllTriggerCols>(SqlSelectCommand, buffered: false);
		}

		public List<VAllTriggerCols> GetTop(int count)
		{
			var queryResult = Query<VAllTriggerCols>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllTriggerCols> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_TRIGGER_COLS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
