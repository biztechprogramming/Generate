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

	public partial class VAllTriggersDap : GenericBaseDap<VAllTriggers>
	{
		public VAllTriggersDap()
		{
		}
		public VAllTriggersDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllTriggersDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllTriggers Map(dynamic result){			
			return new VAllTriggers
			{
				Owner=(String)result.OWNER, TriggerName=(String)result.TRIGGER_NAME, TriggerType=(String)result.TRIGGER_TYPE, TriggeringEvent=(String)result.TRIGGERING_EVENT, TableOwner=(String)result.TABLE_OWNER, BaseObjectType=(String)result.BASE_OBJECT_TYPE, TableName=(String)result.TABLE_NAME, ColumnName=(String)result.COLUMN_NAME, ReferencingNames=(String)result.REFERENCING_NAMES, WhenClause=(String)result.WHEN_CLAUSE, Status=(String)result.STATUS, Description=(String)result.DESCRIPTION, ActionType=(String)result.ACTION_TYPE, TriggerBody=(String)result.TRIGGER_BODY
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllTriggers> All()
		{
			return Query<VAllTriggers>(SqlSelectCommand, buffered: false);
		}

		public List<VAllTriggers> GetTop(int count)
		{
			var queryResult = Query<VAllTriggers>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllTriggers> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_TRIGGERS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
