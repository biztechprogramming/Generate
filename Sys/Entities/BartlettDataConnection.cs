using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace Data
{
	public class BartlettDataConnection
	{
		public static OracleConnection CreateConnection()
		{
			var connection = new OracleConnection(GetConnectionString());
			
			return connection;
		}
		public static string GetConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["BartlettDataConnectionString"].ConnectionString;
		}
	}
}
