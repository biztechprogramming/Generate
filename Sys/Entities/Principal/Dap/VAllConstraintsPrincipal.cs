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

	public partial class VAllConstraintsDap : GenericBaseDap<VAllConstraints>
	{
		public VAllConstraintsDap()
		{
		}
		public VAllConstraintsDap(BaseDap dapProvider)
		{
			if (dapProvider != null &&
				dapProvider.ConnectionContainer != null &&
				dapProvider.ConnectionContainer.Connection != null)
			{
				LeaveOpen = dapProvider.LeaveOpen;
				ConnectionContainer = dapProvider.ConnectionContainer;
			}
		}
		public VAllConstraintsDap(ConnectionContainer connectionContainer, bool leaveOpen)
		{
			if (connectionContainer != null &&
				connectionContainer.Connection != null)
			{
				LeaveOpen = leaveOpen;
				ConnectionContainer = connectionContainer;
			}
		}

		public override VAllConstraints Map(dynamic result){			
			return new VAllConstraints
			{
				Owner=(String)result.OWNER, ConstraintName=(String)result.CONSTRAINT_NAME, ConstraintType=(String)result.CONSTRAINT_TYPE, TableName=(String)result.TABLE_NAME, SearchCondition=(String)result.SEARCH_CONDITION, ROwner=(String)result.R_OWNER, RConstraintName=(String)result.R_CONSTRAINT_NAME, DeleteRule=(String)result.DELETE_RULE, Status=(String)result.STATUS, Deferrable=(String)result.DEFERRABLE, Deferred=(String)result.DEFERRED, Validated=(String)result.VALIDATED, Generated=(String)result.GENERATED, Bad=(String)result.BAD, Rely=(String)result.RELY, LastChange=(DateTime?)result.LAST_CHANGE, IndexOwner=(String)result.INDEX_OWNER, IndexName=(String)result.INDEX_NAME, Invalid=(String)result.INVALID, ViewRelated=(String)result.VIEW_RELATED
			};
		}
		
		/// <summary>
		/// Returns all records from the table.
		/// Please be aware that any predicate cannot be applied to the returned IEnumurable and it will allways read all records.
		/// </summary>
		/// <returns>Delayed read all records from the database table.</returns>
		public IEnumerable<VAllConstraints> All()
		{
			return Query<VAllConstraints>(SqlSelectCommand, buffered: false);
		}

		public List<VAllConstraints> GetTop(int count)
		{
			var queryResult = Query<VAllConstraints>(string.Format("SELECT * FROM {1} WHERE ROWNUM<={0}", count, SqlTableName));
			return queryResult as List<VAllConstraints> ?? queryResult.ToList();
		}





		public const string SqlTableName = "SYS.ALL_CONSTRAINTS";
		public const string SqlSelectCommand = "SELECT * FROM " + SqlTableName;
	}

}
