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
	/// User custom methods for VAllTablesDap
	/// </summary>
	partial class VAllTablesDap
	{
		public List<VAllTables> GetByTableName(string tableName)
		{
			return GetByTableName(tableName, "BTREE");
		}
		public List<VAllTables> GetByTableName(string tableName, string owner)
		{
			var queryResult = Query<VAllTables>(string.Format("SELECT * FROM {0} WHERE TABLE_NAME = '{1}' AND OWNER = '{2}", SqlTableName, tableName, owner));
			return queryResult as List<VAllTables> ?? queryResult.ToList();
		}
	}
}
