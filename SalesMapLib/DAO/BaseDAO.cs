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

namespace SalesMapLib.DAO
{
    public class BaseDAO
    {
        private IDBCore db;

        public BaseDAO()
        {
            db = new SQLServerCore();
        }
        public virtual T QueryFirst<T>(string sql, object vo)
        {
            return db.QueryFirst<T>(sql, vo);
        }

        public virtual IEnumerable<T> Query<T>(string sql, object vo)
        {
            sql = SelectCommand_Add_SystemColumn(sql, vo);
            return db.Query<T>(sql, vo);
        }

        public virtual int Excute(string sql, object vo)
        {
            return db.Execute(sql, vo);
        }

        public virtual int Transaction(string sql, object vo)
        {
            throw new NotImplementedException();
        }
        public virtual int StorePocedure(string sql, object vo)
        {
            throw new NotImplementedException();
        }

        private string SelectCommand_Add_SystemColumn(string sql, object vo)
        {
            if (!sql.Contains("{0}", StringComparison.CurrentCulture)) throw new Exception("SelectCommand_Add_SystemColumn需要包含\"{0}\"的字串");
            if (!sql.Contains("{1}", StringComparison.CurrentCulture)) throw new Exception("SelectCommand_Add_SystemColumn需要包含\"{1}\"的字串");

            string column = "";
            string condition = "";

            Type type = vo.GetType();

            if (type.BaseType?.Name == "Base") 
            {
                PropertyInfo[] propertyInfos = type.GetProperties();

                foreach (PropertyInfo property in propertyInfos)
                {
                    if (property.GetCustomAttribute(typeof(SystemColumnAttribute)) != null)
                    {
                        column += $", {property.Name} ";
                        condition += $"and {property.Name}=@{property.Name} ";
                    }
                }
            }

            sql = string.Format(sql, column, condition);

            return sql;
        }
        private string InsertCommand_Add_SystemColumn(string sql, object vo)
        {
            if (!sql.Contains("{0}", StringComparison.CurrentCulture)) throw new Exception("InsertCommand_Add_SystemColumn需要包含\"{0}\"的字串");
            if (!sql.Contains("{1}", StringComparison.CurrentCulture)) throw new Exception("InsertCommand_Add_SystemColumn需要包含\"{1}\"的字串");

            string column = "";
            string parameter = "";

            Type type = vo.GetType();

            if (type.BaseType?.Name == "Base")
            {
                PropertyInfo[] propertyInfos = type.GetProperties();

                foreach (PropertyInfo property in propertyInfos)
                {
                    if (property.GetCustomAttribute(typeof(SystemColumnAttribute)) != null)
                    {
                        column += $", {property.Name} ";
                        parameter += $", @{property.Name} ";
                    }
                }
            }

            sql = string.Format(sql, column, parameter);

            return sql;
        }
        private string UpdateCommand_Add_SystemColumn(string sql, object vo)
        {
            if (!sql.Contains("{0}", StringComparison.CurrentCulture)) throw new Exception("UpdateCommand_Add_SystemColumn需要包含\"{0}\"的字串");
            if (!sql.Contains("{1}", StringComparison.CurrentCulture)) throw new Exception("UpdateCommand_Add_SystemColumn需要包含\"{1}\"的字串");

            string column = "";
            string condition = "";

            Type type = vo.GetType();

            if (type.BaseType?.Name == "Base")
            {
                PropertyInfo[] propertyInfos = type.GetProperties();

                foreach (PropertyInfo property in propertyInfos)
                {
                    if (property.GetCustomAttribute(typeof(SystemColumnAttribute)) != null)
                    {
                        column += $", {property.Name}=@{property.Name} ";
                        condition += $"and {property.Name}=@{property.Name} ";
                    }
                }
            }

            sql = string.Format(sql, column, condition);

            return sql;
        }
        private string DeleteCommand_Add_SystemColumn(string sql, object vo)
        {
            if (!sql.Contains("{0}", StringComparison.CurrentCulture)) throw new Exception("DeleteCommand_Add_SystemColumn需要包含\"{0}\"的字串");

            string condition = "";

            Type type = vo.GetType();

            if (type.BaseType?.Name == "Base")
            {
                PropertyInfo[] propertyInfos = type.GetProperties();

                foreach (PropertyInfo property in propertyInfos)
                {
                    if (property.GetCustomAttribute(typeof(SystemColumnAttribute)) != null)
                    {
                        condition += $"and {property.Name}=@{property.Name} ";
                    }
                }
            }

            sql = string.Format(sql, condition);

            return sql;
        }
    }
}
