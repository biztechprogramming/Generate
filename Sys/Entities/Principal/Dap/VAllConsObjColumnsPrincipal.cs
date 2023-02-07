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

	public partial class VAllConsObjColumnsDap : GenericBaseDap<VAllConsObjColumns>
	{
		public VAllConsObjColumnsDap()
		{
		}
		public VAllConsObjColumnsDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllConsObjColumnsDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllConsObjColumns Map(dynamic result){			
			return new VAllConsObjColumns
			{
				Owner=(String)result.OWNER, TableName=(String)result.TABLE_NAME, ColumnName=(String)result.COLUMN_NAME, ConsTypeOwner=(String)result.CONS_TYPE_OWNER, ConsTypeName=(String)result.CONS_TYPE_NAME, ConsTypeOnly=(String)result.CONS_TYPE_ONLY
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllConsObjColumns> All()
		{
			return Query<VAllConsObjColumns>(SqlSelectCommand, buffered: false);
		}

		public List<VAllConsObjColumns> GetTop(int count)
		{
			var queryResult = Query<VAllConsObjColumns>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllConsObjColumns> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_CONS_OBJ_COLUMNS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
