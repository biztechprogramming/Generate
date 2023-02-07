using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace Data.Base
{
    public abstract class GenericBaseDap<T> : BaseDap
    {
        public abstract T Map(dynamic result);

        /// <summary>
        /// Return a list of dynamic objects, reader is closed after the call
        /// </summary>
        public List<dynamic> Query(string sql, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            var items = new List<dynamic>();

            if (transaction == null)
                transaction = _connectionContainer.Transaction;
            
            return new List<dynamic>(SqlMapper.Query(_connectionContainer.Connection, sql, param, transaction, buffered, commandTimeout, commandType));
        }

        /// <summary>
        /// Executes a query, returning the data typed as per T
        /// </summary>
        /// <remarks>the dynamic param may seem a bit odd, but this works around a major usability issue in vs, if it is Object vs completion gets annoying. Eg type new [space] get new object</remarks>
        /// <returns>A sequence of data of the supplied type; if a basic type (int, string, etc) is queried then the data from the first column in assumed, otherwise an instance is
        /// created per row, and a direct column-name===member-name mapping is assumed (case insensitive).
        /// </returns>
        public List<TReturn> Query<TReturn>(string sql, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            var items = new List<TReturn>();

            if (transaction == null)
                transaction = _connectionContainer.Transaction;
            
            List<dynamic> query = new List<dynamic>(SqlMapper.Query(_connectionContainer.Connection, sql, param, transaction, buffered, commandTimeout, commandType));

            for (int i = 0; i < query.Count; i++)
            {
                items.Add(Map(query[i]));
            }
            return AssignOwner(items);
        }

        /// <summary>
        /// Maps a query to objects
        /// </summary>
        public List<TReturn> Query<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var items = new List<TReturn>();

            if (transaction == null)
                transaction = _connectionContainer.Transaction;
            
            items.AddRange(new List<TReturn>(SqlMapper.Query<TFirst, TSecond, TReturn>(_connectionContainer.Connection, sql, map, param, transaction, buffered, splitOn,
                                                                                                                commandTimeout, commandType)));
            
            return AssignOwner(items);
        }

        /// <summary>
        /// Perform a multi mapping query with 5 input parameters
        /// </summary>
        public List<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var items = new List<TReturn>();

            if (transaction == null)
                transaction = _connectionContainer.Transaction;

            items.AddRange(new List<TReturn>(SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(_connectionContainer.Connection, sql, map, param, transaction, buffered, splitOn,
                                                                                                                commandTimeout, commandType)));
            
            return AssignOwner(items);
        }

        /// <summary>
        /// Perform a multi mapping query with 4 input parameters
        /// </summary>
        public List<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var items = new List<TReturn>();

            if (transaction == null)
                transaction = _connectionContainer.Transaction;

            items.AddRange(new List<TReturn>(SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TReturn>(_connectionContainer.Connection, sql, map, param, transaction, buffered, splitOn,
                                                                                                                commandTimeout, commandType)));
            
            return AssignOwner(items);
        }

        /// <summary>
        /// Maps a query to objects
        /// </summary>
        public List<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, dynamic param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            var items = new List<TReturn>();

            if (transaction == null)
                transaction = _connectionContainer.Transaction;

            items.AddRange(new List<TReturn>(SqlMapper.Query<TFirst, TSecond, TThird, TReturn>(_connectionContainer.Connection, sql, map, param, transaction, buffered, splitOn,
                                                                                                                commandTimeout, commandType)));
            
            return AssignOwner(items);
        }
    }
}
