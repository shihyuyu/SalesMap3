using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class UserPermissionDAO : BaseDAO
    {
        public IEnumerable<UserPermission> Select(UserPermission vo)
        {
            string condition = "";

            if (vo.ID != null)
            {
                condition += "and ID=@ID ";
            }
            if (vo.UserId != null)
            {
                condition += "and UserId=@UserId ";
            }
            if (vo.FunctionID != null)
            {
                condition += "and FunctionID=@FunctionID ";
            }
            if (vo.Visible != null)
            {
                condition += "and Visible=@Visible ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from UserPermission where {condition} {{1}}";


            return Query<UserPermission>(sql, vo);
        }
        public int Insert(UserPermission vo)
        {
            string column = "";
            string parameter = "";

            if (vo.ID != null)
            {
                column += ", ID ";
                parameter += ", @ID ";
            }
            if (vo.UserId != null)
            {
                column += ", UserId ";
                parameter += ", @UserId ";
            }
            if (vo.FunctionID != null)
            {
                column += ", FunctionID ";
                parameter += ", @FunctionID ";
            }
            if (vo.Visible != null)
            {
                column += ", Visible ";
                parameter += ", @Visible ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into UserPermission( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(UserPermission vo)
        {
            string column = "";

            if (vo.ID == null)
            {
                throw new Exception("PrimayKey欄位ID不可為NULL");
            }
            if (vo.UserId != null)
            {
                column += ", UserId=@UserId ";
            }
            if (vo.FunctionID != null)
            {
                column += ", FunctionID=@FunctionID ";
            }
            if (vo.Visible != null)
            {
                column += ", Visible=@Visible ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update UserPermission set {column} where ID=@ID";

            return Excute(sql, vo);
        }
        public int Delete(UserPermission vo)
        {
            string condition = "";

            if (vo.ID != null)
            {
                condition += "and ID=@ID ";
            }
            if (vo.UserId != null)
            {
                condition += "and UserId=@UserId ";
            }
            if (vo.FunctionID != null)
            {
                condition += "and FunctionID=@FunctionID ";
            }
            if (vo.Visible != null)
            {
                condition += "and Visible=@Visible ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from UserPermission where {condition}";

            return Excute(sql, vo);
        }
    }
}
