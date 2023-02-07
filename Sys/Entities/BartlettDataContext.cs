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
	public partial class BartlettDataContext : IDisposable
	{
		private ConnectionContainer _connectionContainer;

		public ConnectionContainer DbConnection
		{
			get { return _connectionContainer; }
			set { _connectionContainer = value; }
		}

		private VAllObjectsDap _VAllObjects;
		public VAllObjectsDap VAllObjects
		{
			get
			{
				if (_VAllObjects == null)
				{
					_VAllObjects = new VAllObjectsDap();
				}
				return _VAllObjects;
			}
		}

		private VAllTabColumnsDap _VAllTabColumns;
		public VAllTabColumnsDap VAllTabColumns
		{
			get
			{
				if (_VAllTabColumns == null)
				{
					_VAllTabColumns = new VAllTabColumnsDap();
				}
				return _VAllTabColumns;
			}
		}

		private VAllIndexesDap _VAllIndexes;
		public VAllIndexesDap VAllIndexes
		{
			get
			{
				if (_VAllIndexes == null)
				{
					_VAllIndexes = new VAllIndexesDap();
				}
				return _VAllIndexes;
			}
		}

		private VAllTablesDap _VAllTables;
		public VAllTablesDap VAllTables
		{
			get
			{
				if (_VAllTables == null)
				{
					_VAllTables = new VAllTablesDap();
				}
				return _VAllTables;
			}
		}

		private VAllConstraintsDap _VAllConstraints;
		public VAllConstraintsDap VAllConstraints
		{
			get
			{
				if (_VAllConstraints == null)
				{
					_VAllConstraints = new VAllConstraintsDap();
				}
				return _VAllConstraints;
			}
		}

		private VAllConsColumnsDap _VAllConsColumns;
		public VAllConsColumnsDap VAllConsColumns
		{
			get
			{
				if (_VAllConsColumns == null)
				{
					_VAllConsColumns = new VAllConsColumnsDap();
				}
				return _VAllConsColumns;
			}
		}

		private VAllTriggersDap _VAllTriggers;
		public VAllTriggersDap VAllTriggers
		{
			get
			{
				if (_VAllTriggers == null)
				{
					_VAllTriggers = new VAllTriggersDap();
				}
				return _VAllTriggers;
			}
		}

		private VAllTriggerColsDap _VAllTriggerCols;
		public VAllTriggerColsDap VAllTriggerCols
		{
			get
			{
				if (_VAllTriggerCols == null)
				{
					_VAllTriggerCols = new VAllTriggerColsDap();
				}
				return _VAllTriggerCols;
			}
		}

		private VAllTabColsDap _VAllTabCols;
		public VAllTabColsDap VAllTabCols
		{
			get
			{
				if (_VAllTabCols == null)
				{
					_VAllTabCols = new VAllTabColsDap();
				}
				return _VAllTabCols;
			}
		}

		private VAllConsObjColumnsDap _VAllConsObjColumns;
		public VAllConsObjColumnsDap VAllConsObjColumns
		{
			get
			{
				if (_VAllConsObjColumns == null)
				{
					_VAllConsObjColumns = new VAllConsObjColumnsDap();
				}
				return _VAllConsObjColumns;
			}
		}

		public BartlettDataContext()
		{
			DbConnection = new ConnectionContainer()
			{
				Connection = BartlettDataConnection.CreateConnection()
			};
		}

		public IDbTransaction BeginTransaction()
		{
			DbConnection.OpenConnection();
			DbConnection.Transaction = DbConnection.Connection.BeginTransaction();
			return DbConnection.Transaction;
		}

		public IDbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			DbConnection.OpenConnection();
			DbConnection.Transaction = DbConnection.Connection.BeginTransaction(isolationLevel);
			return DbConnection.Transaction;
		}

		public void CommitTransaction()
		{
			DbConnection.Transaction.Commit();
		}

		public void Dispose()
		{

			if (_VAllObjects != null)
				_VAllObjects.Dispose();
			_VAllObjects = null;

			if (_VAllTabColumns != null)
				_VAllTabColumns.Dispose();
			_VAllTabColumns = null;

			if (_VAllIndexes != null)
				_VAllIndexes.Dispose();
			_VAllIndexes = null;

			if (_VAllTables != null)
				_VAllTables.Dispose();
			_VAllTables = null;

			if (_VAllConstraints != null)
				_VAllConstraints.Dispose();
			_VAllConstraints = null;

			if (_VAllConsColumns != null)
				_VAllConsColumns.Dispose();
			_VAllConsColumns = null;

			if (_VAllTriggers != null)
				_VAllTriggers.Dispose();
			_VAllTriggers = null;

			if (_VAllTriggerCols != null)
				_VAllTriggerCols.Dispose();
			_VAllTriggerCols = null;

			if (_VAllTabCols != null)
				_VAllTabCols.Dispose();
			_VAllTabCols = null;

			if (_VAllConsObjColumns != null)
				_VAllConsObjColumns.Dispose();
			_VAllConsObjColumns = null;

			if (_connectionContainer != null)
				_connectionContainer.Dispose();
			_connectionContainer = null;
		}
	}
}
