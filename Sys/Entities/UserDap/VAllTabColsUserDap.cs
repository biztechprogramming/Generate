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
	/// <summary>
	/// User custom methods for VAllTabColsDap
	/// </summary>
	partial class VAllTabColsDap
	{
		public List<VAllTabCols> GetByTableName(string tableName)
		{
			return GetByTableName(tableName, "BTREE");
		}
		public List<VAllTabCols> GetByTableName(string tableName, string owner)
		{
			var queryResult = Query<VAllTabCols>(string.Format("SELECT * FROM {0} WHERE TABLE_NAME = '{1}' AND OWNER = '{2}' ORDER BY COLUMN_ID", SqlTableName, tableName, owner));
			return queryResult as List<VAllTabCols> ?? queryResult.ToList();
		}
	}
}
