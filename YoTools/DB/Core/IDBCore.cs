using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoTools.DB.Core
{
    public interface IDBCore
    {
        /// <summary>
        /// 執行 SQL 語法
        /// </summary>
        /// <param name="SQL">SQL</param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string SQL, CommandType? commandType = null);
        /// <summary>
        /// 執行 SQL 語法
        /// </summary>
        /// <param name="SQL">SQL</param>
        /// <param name="parameters">多參數組</param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 SQL 語法
        /// </summary>
        /// <param name="SQL">SQL</param>
        /// <param name="parameters">參數</param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string SQL, object parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 SQL 語法
        /// </summary>
        /// <param name="SQL">SQL</param>
        /// <param name="parameters">多參數組</param>
        /// <returns></returns>
        public int Execute(string SQL, IEnumerable<IDictionary<string, object>> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 SQL 語法
        /// </summary>
        /// <param name="SQL">SQL</param>
        /// <param name="parameters">多參數組</param>
        /// <returns></returns>
        public int Execute(string SQL, IEnumerable<object> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 SQL 語法
        /// </summary>
        /// <param name="SQL">SQL</param>
        /// <param name="parameters">多參數組</param>
        /// <returns></returns>
        public int Transaction(string SQL, IEnumerable<IDictionary<string, object>> parameters, CommandType? commandType = null);
        /// <summary>
        /// 多道SQL指令與相同數量的 parameter 一同執行
        /// </summary>
        /// <returns></returns>
        public int Transaction(IEnumerable<string> SQLArray, IEnumerable<IDictionary<string, object>> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 Query 取第一筆回傳 IDictionary<string, object>
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> QueryFirst(string SQL, CommandType? commandType = null);
        /// <summary>
        /// 執行 Query 取第一筆回傳 IDictionary<string, object>
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> QueryFirst(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 Query 取第一筆回傳 IDictionary<string, object>
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> QueryFirst(string SQL, object parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行語法 QueryFirst 取第一筆回傳 T
        /// </summary>
        public T QueryFirst<T>(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行語法 QueryFirst 取第一筆回傳 T
        /// </summary>
        public T QueryFirst<T>(string commandText, object parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行 Query 回傳 IEnumerable<IDictionary<string, object>>
        /// </summary>
        public IEnumerable<IDictionary<string, object>> Query(string SQL, CommandType? commandType = null);
        /// <summary>
        /// 執行 Query 回傳 IEnumerable<IDictionary<string, object>>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IDictionary<string, object>> Query(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行語法 Query 回傳 IEnumerable<T>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string SQL, IDictionary<string, object> parameters, CommandType? commandType = null);
        /// <summary>
        /// 執行語法 Query 回傳 IEnumerable<T>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string sql, object vo);
        /// <summary>
        /// 執行語法 Query 回傳 IEnumerable<T>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string SQL, CommandType? commandType = null);
    }
}
