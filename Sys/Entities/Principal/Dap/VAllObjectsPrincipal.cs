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

	public partial class VAllObjectsDap : GenericBaseDap<VAllObjects>
	{
		public VAllObjectsDap()
		{
		}
		public VAllObjectsDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllObjectsDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllObjects Map(dynamic result){			
			return new VAllObjects
			{
				Owner=(String)result.OWNER, ObjectName=(String)result.OBJECT_NAME, SubobjectName=(String)result.SUBOBJECT_NAME, ObjectId=(Decimal)result.OBJECT_ID, DataObjectId=(Decimal?)result.DATA_OBJECT_ID, ObjectType=(String)result.OBJECT_TYPE, Created=(DateTime)result.CREATED, LastDdlTime=(DateTime)result.LAST_DDL_TIME, Timestamp=(String)result.TIMESTAMP, Status=(String)result.STATUS, Temporary=(String)result.TEMPORARY, Generated=(String)result.GENERATED, Secondary=(String)result.SECONDARY
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllObjects> All()
		{
			return Query<VAllObjects>(SqlSelectCommand, buffered: false);
		}

		public List<VAllObjects> GetTop(int count)
		{
			var queryResult = Query<VAllObjects>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllObjects> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_OBJECTS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
