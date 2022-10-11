using SalesMapLib.VO.BaseModels;
using SalesMapLib.VO.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoTools.DB.Core;
using YoTools.DB.SQLServer;

namespace SalesMapLib.BO
{
    public class BaseBO
    {
        /// <summary>
        /// VO型別
        /// </summary>
        private static Type? VOType;
        /// <summary>
        /// DAO型別
        /// </summary>
        private static Type? DAOType { get { return Type.GetType(DAOName); } }
        /// <summary>
        /// DAO完整名稱
        /// </summary>
        private static string DAOName { get { return $"SalesMapLib.DAO.{VOType.Name + "DAO"}"; } }

        /// <summary>
        /// 查詢單一筆資料
        /// </summary>
        /// <typeparam name="T">動態物件</typeparam>
        /// <param name="id">唯一索引 Primary Key</param>
        /// <returns></returns>
        public static T Get<T>(object id)
        {
            T result = default(T);

            VOType = typeof(T);

            if (VOType != null && DAOType != null)
            {
                var MyDAO = Activator.CreateInstance(DAOType);
                var MyVO = Activator.CreateInstance(VOType);

                VOType.GetProperty("CodeID").SetValue(MyVO, id) ;

                var MyReturn = DAOType.GetMethod("Select", 0, new Type[] { VOType }, null).Invoke(MyDAO, new object[] { MyVO });
                result = ((List<T>)MyReturn).FirstOrDefault((T)Activator.CreateInstance(VOType));
            }

            return result;
        }
        /// <summary>
        /// 查詢多筆資料
        /// </summary>
        /// <typeparam name="T">動態物件</typeparam>
        /// <param name="vo">查詢物件</param>
        /// <returns></returns>
        public static IEnumerable<T> GetList<T>(T vo)
        {
            IEnumerable<T> result = default(List<T>);

            VOType = typeof(T);

            if (VOType != null && DAOType != null)
            {
                var MyDAO = Activator.CreateInstance(DAOType);

                var MyReturn = DAOType.GetMethod("Select", 0, new Type[] { VOType }, null).Invoke(MyDAO, new object[] { vo });
                result = ((List<T>)MyReturn);
            }

            return result;
        }
        /// <summary>
        /// 新增 一筆資料
        /// </summary>
        /// <typeparam name="T">動態物件</typeparam>
        /// <param name="vo">新增物件</param>
        /// <returns></returns>
        public static bool Insert<T>(T vo)
        {
            bool result = false;

            VOType = typeof(T);

            if (VOType != null && DAOType != null)
            {
                var MyDAO = Activator.CreateInstance(DAOType);

                var MyReturn = DAOType.GetMethod("Insert", 0, new Type[] { VOType }, null).Invoke(MyDAO, new object[] { vo });
                result = (int)MyReturn > 0;
            }

            return result;
        }
        /// <summary>
        /// 更新單一筆資料
        /// </summary>
        /// <typeparam name="T">動態物件</typeparam>
        /// <param name="vo">更新物件</param>
        /// <returns></returns>
        public static bool Update<T>(T vo)
        {
            bool result = false;

            VOType = typeof(T);

            if (VOType != null && DAOType != null)
            {
                var MyDAO = Activator.CreateInstance(DAOType);

                var MyReturn = DAOType.GetMethod("Update", 0, new Type[] { VOType }, null).Invoke(MyDAO, new object[] { vo });
                result = (int)MyReturn > 0;
            }

            return result;
        }
        /// <summary>
        /// 刪除單一筆資料
        /// </summary>
        /// <typeparam name="T">動態物件</typeparam>
        /// <param name="id">唯一索引 Primary Key</param>
        /// <returns></returns>
        public static bool Delete<T>(object id)
        {
            bool result = false;

            VOType = typeof(T);

            if (VOType != null && DAOType != null)
            {
                var MyDAO = Activator.CreateInstance(DAOType);
                var MyVO = Activator.CreateInstance(VOType);

                VOType.GetProperty("CodeID").SetValue(MyVO, id);

                var MyReturn = DAOType.GetMethod("Delete", 0, new Type[] { VOType }, null).Invoke(MyDAO, new object[] { MyVO });
                result = (int)MyReturn > 0;
            }

            return result;
        }
    }
}
