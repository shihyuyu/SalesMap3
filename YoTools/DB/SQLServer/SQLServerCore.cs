using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoTools.DB.Core;

namespace YoTools.DB.SQLServer
{
    public class SQLServerCore : IDBCore
    {
        public string ConnectionString = "";
        public int Execute(string SQL, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }

        public int Execute(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }

        public int Execute(string commandText, object parameters, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }

        public int Execute(string SQL, IEnumerable<IDictionary<string, object>> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }

        public int Execute(string SQL, IEnumerable<object> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }

        public IEnumerable<IDictionary<string, object>> Query(string SQL, CommandType? commandType = null)
        {
#if DEBUG
            return new List<Dictionary<string, object>>();
#endif
            throw new NotImplementedException();
        }

        public IEnumerable<IDictionary<string, object>> Query(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return new List<Dictionary<string, object>>();
#endif
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return new List<T>();
#endif
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string SQL, CommandType? commandType = null)
        {
#if DEBUG

            return new List<T>();
#endif
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string sql, object vo)
        {
#if DEBUG
            return new List<T>();
#endif
            throw new NotImplementedException();
        }

        public IDictionary<string, object> QueryFirst(string SQL, CommandType? commandType = null)
        {
#if DEBUG
            return new Dictionary<string, object>();
#endif
            throw new NotImplementedException();
        }

        public IDictionary<string, object> QueryFirst(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return new Dictionary<string, object>();
#endif
            throw new NotImplementedException();
        }

        public IDictionary<string, object> QueryFirst(string SQL, object parameters, CommandType? commandType = null)
        {
#if DEBUG
            return new Dictionary<string, object>();
#endif
            throw new NotImplementedException();
        }

        public T QueryFirst<T>(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return (T)new object();
#endif
            throw new NotImplementedException();
        }

        public T QueryFirst<T>(string commandText, object parameters, CommandType? commandType = null)
        {
#if DEBUG
            return (T)new object();
#endif
            throw new NotImplementedException();
        }

        public int Transaction(string SQL, IEnumerable<IDictionary<string, object>> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }

        public int Transaction(IEnumerable<string> SQLArray, IEnumerable<IDictionary<string, object>> parameters, CommandType? commandType = null)
        {
#if DEBUG
            return 1;
#endif
            throw new NotImplementedException();
        }
    }
}
