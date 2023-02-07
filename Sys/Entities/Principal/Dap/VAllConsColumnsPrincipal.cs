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

	public partial class VAllConsColumnsDap : GenericBaseDap<VAllConsColumns>
	{
		public VAllConsColumnsDap()
		{
		}
		public VAllConsColumnsDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllConsColumnsDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllConsColumns Map(dynamic result){			
			return new VAllConsColumns
			{
				Owner=(String)result.OWNER, ConstraintName=(String)result.CONSTRAINT_NAME, TableName=(String)result.TABLE_NAME, ColumnName=(String)result.COLUMN_NAME, Position=(Decimal?)result.POSITION
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllConsColumns> All()
		{
			return Query<VAllConsColumns>(SqlSelectCommand, buffered: false);
		}

		public List<VAllConsColumns> GetTop(int count)
		{
			var queryResult = Query<VAllConsColumns>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllConsColumns> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_CONS_COLUMNS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
