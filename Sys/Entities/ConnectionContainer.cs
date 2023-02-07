using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace Data
{
	public class ConnectionContainer : IDisposable
	{
		public ConnectionContainer()
		{
			Connection = BartlettDataConnection.CreateConnection();
		}
		private IDbConnection _connection { get; set; }

		public IDbConnection Connection
		{
			get { return _connection; }
			set { _connection = value; }
		}

		private IDbTransaction _transaction;

		public IDbTransaction Transaction
		{
			get { return _transaction; }
			set
			{
				_transaction = value;
				if (_transaction != null)
					_connection = _transaction.Connection;
			}
		}

		internal void OpenConnection()
		{
			if (_connection != null && _connection.State != ConnectionState.Open)
				_connection.Open();
		}

		internal void CloseConnection()
		{
			if (_connection != null)
				_connection.Close();
		}

		public void Dispose()
		{
			if (_transaction != null)
				_transaction.Dispose();

			if (_connection != null)
				_connection.Dispose();

			_transaction = null;
			_connection = null;
		}
	}
}
