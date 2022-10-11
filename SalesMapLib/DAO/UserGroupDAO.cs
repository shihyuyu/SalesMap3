using SalesMapLib.VO.BaseModels;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class UserGroupDAO : BaseDAO
    {
        public IEnumerable<UserGroup> Select(UserGroup vo)
        {
            string condition = "";

            if (vo.ID != null)
            {
                condition += "and ID=@ID ";
            }
            if (vo.UserID != null)
            {
                condition += "and UserID=@UserID ";
            }
            if (vo.CustomerID != null)
            {
                condition += "and CustomerID=@CustomerID ";
            }
            if (vo.RoleLevel != null)
            {
                condition += "and RoleLevel=@RoleLevel ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from UserGroup where {condition} {{1}}";


            return Query<UserGroup>(sql, vo);
        }
        public int Insert(UserGroup vo)
        {
            string column = "";
            string parameter = "";

            if (vo.ID != null)
            {
                column += ", ID ";
                parameter += ", @ID ";
            }
            if (vo.UserID != null)
            {
                column += ", UserID ";
                parameter += ", @UserID ";
            }
            if (vo.CustomerID != null)
            {
                column += ", CustomerID ";
                parameter += ", @CustomerID ";
            }
            if (vo.RoleLevel != null)
            {
                column += ", RoleLevel ";
                parameter += ", @RoleLevel ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into UserGroup( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(UserGroup vo)
        {
            string column = "";

            if (vo.ID == null)
            {
                throw new Exception("PrimayKey欄位ID不可為NULL");
            }
            if (vo.UserID != null)
            {
                column += ", UserID=@UserID ";
            }
            if (vo.CustomerID != null)
            {
                column += ", CustomerID=@CustomerID ";
            }
            if (vo.RoleLevel != null)
            {
                column += ", RoleLevel=@RoleLevel ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update UserGroup set {column} where ID=@ID";

            return Excute(sql, vo);
        }
        public int Delete(UserGroup vo)
        {
            string condition = "";

            if (vo.ID != null)
            {
                condition += "and ID=@ID ";
            }
            if (vo.UserID != null)
            {
                condition += "and UserID=@UserID ";
            }
            if (vo.CustomerID != null)
            {
                condition += "and CustomerID=@CustomerID ";
            }
            if (vo.RoleLevel != null)
            {
                condition += "and RoleLevel=@RoleLevel ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from UserGroup where {condition}";

            return Excute(sql, vo);
        }
    }
}
