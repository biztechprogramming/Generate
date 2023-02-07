using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Data.Entities;
using Dapper;

namespace Data.Base
{
	public abstract partial class BaseDap : IDisposable
	{
		protected ConnectionContainer _connectionContainer;
		protected bool _leaveOpen;

		protected internal BaseDap()
		{
			_connectionContainer = new ConnectionContainer();
		}
		protected internal BaseDap(ConnectionContainer container, bool leaveOpen)
		{
			_leaveOpen = leaveOpen;
			_connectionContainer = container;
		}

		public ConnectionContainer ConnectionContainer
		{
			get { return _connectionContainer; }
			protected set { _connectionContainer = value; }
		}

		protected internal bool LeaveOpen
		{
			get { return _leaveOpen; }
			set { _leaveOpen = value; }
		}

		public IDbTransaction BeginTransaction()
		{
			OpenConnection();
			_connectionContainer.Transaction = _connectionContainer.Connection.BeginTransaction();
			return _connectionContainer.Transaction;
		}

		public IDbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			OpenConnection();
			_connectionContainer.Transaction = _connectionContainer.Connection.BeginTransaction(isolationLevel);
			return _connectionContainer.Transaction;
		}

		/// <summary>
		/// Execute parameterized SQL  
		/// </summary>
		/// <returns>Number of rows affected</returns>
		public int Execute(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
		{
			if (transaction == null)
				transaction = _connectionContainer.Transaction;

			return SqlMapper.Execute(_connectionContainer.Connection, sql, param, transaction, commandTimeout, commandType);
		}

		/// <summary>
		/// Execute scalar SQL  
		/// </summary>
		/// <returns>T</returns>
		public T ExecuteScaler<T>(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
		{
			if (transaction == null)
				transaction = _connectionContainer.Transaction;

			return SqlMapper.ExecuteScalar<T>(_connectionContainer.Connection, sql, param, transaction, commandTimeout, commandType);
		}

		/// <summary>
		/// Execute a command that returns multiple result sets, and access each in turn
		/// </summary>
		public SqlMapper.GridReader QueryMultiple(string sql, dynamic param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
		{
			if (transaction == null)
				transaction = _connectionContainer.Transaction;

			return SqlMapper.QueryMultiple(_connectionContainer.Connection, sql, param, transaction, commandTimeout, commandType);
		}

		protected void OpenConnection()
		{
			_connectionContainer.OpenConnection();
		}

		protected void CloseConnection()
		{
			_connectionContainer.CloseConnection();
		}

		protected List<T> AssignOwner<T>(List<T> data)
		{
			if (!typeof(T).IsSubclassOf(typeof(BaseModel)))
			{
				return data;
			}
			return new List<T>(new DapperModelQuery<T>(data, _connectionContainer));
		}

		protected IList<T> AssignOwner<T>(IList<T> data)
		{
			if (!typeof(T).IsSubclassOf(typeof(BaseModel)))
			{
				return data;
			}
			for (int i = 0; i < data.Count; i++)
			{
				var baseModel = data[i] as BaseModel;
				if (baseModel != null)
					baseModel.DbConnection = _connectionContainer;
			}
			return data;
		}
		protected void AssignListOwner<T>(IList<T> data) where T : BaseModel
		{
			for (int i = 0; i < data.Count; i++)
			{
				data[i].DbConnection = _connectionContainer;
			}
		}
		protected void AssignModelOwner<T>(T data) where T : BaseModel
		{
			if (data != null)
				data.DbConnection = _connectionContainer;
		}

		public void Dispose()
		{
			_connectionContainer.Dispose();
			_connectionContainer = null;
		}
	}
}
