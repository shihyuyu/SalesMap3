using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class UserAccountDAO : BaseDAO
    {
        public IEnumerable<UserAccount> Select(UserAccount vo)
        {
            string condition = "";

            if (vo.UserID != null)
            {
                condition += "and UserID=@UserID ";
            }
            if (vo.Account != null)
            {
                condition += "and Account=@Account ";
            }
            if (vo.Password != null)
            {
                condition += "and Password=@Password ";
            }
            if (vo.ErrorCounts != null)
            {
                condition += "and ErrorCounts=@ErrorCounts ";
            }
            if (vo.IsPasswordExpired != null)
            {
                condition += "and IsPasswordExpired=@IsPasswordExpired ";
            }
            if (vo.PasswordExpiredDate != null)
            {
                condition += "and PasswordExpiredDate=@PasswordExpiredDate ";
            }
            if (vo.StartDate != null)
            {
                condition += "and StartDate=@StartDate ";
            }
            if (vo.EndDate != null)
            {
                condition += "and EndDate=@EndDate ";
            }
            if (vo.State != null)
            {
                condition += "and State=@State ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from UserAccount where {condition} {{1}}";


            return Query<UserAccount>(sql, vo);
        }
        public int Insert(UserAccount vo)
        {
            string column = "";
            string parameter = "";

            if (vo.UserID != null)
            {
                column += ", UserID ";
                parameter += ", @UserID ";
            }
            if (vo.Account != null)
            {
                column += ", Account ";
                parameter += ", @Account ";
            }
            if (vo.Password != null)
            {
                column += ", Password ";
                parameter += ", @Password ";
            }
            if (vo.ErrorCounts != null)
            {
                column += ", ErrorCounts ";
                parameter += ", @ErrorCounts ";
            }
            if (vo.IsPasswordExpired != null)
            {
                column += ", IsPasswordExpired ";
                parameter += ", @IsPasswordExpired ";
            }
            if (vo.PasswordExpiredDate != null)
            {
                column += ", PasswordExpiredDate ";
                parameter += ", @PasswordExpiredDate ";
            }
            if (vo.StartDate != null)
            {
                column += ", StartDate ";
                parameter += ", @StartDate ";
            }
            if (vo.EndDate != null)
            {
                column += ", EndDate ";
                parameter += ", @EndDate ";
            }
            if (vo.State != null)
            {
                column += ", State ";
                parameter += ", @State ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into UserAccount( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(UserAccount vo)
        {
            string column = "";

            if (vo.UserID == null)
            {
                throw new Exception("PrimayKey欄位UserID不可為NULL");
            }
            if (vo.Account != null)
            {
                column += ", Account=@Account ";
            }
            if (vo.Password != null)
            {
                column += ", Password=@Password ";
            }
            if (vo.ErrorCounts != null)
            {
                column += ", ErrorCounts=@ErrorCounts ";
            }
            if (vo.IsPasswordExpired != null)
            {
                column += ", IsPasswordExpired=@IsPasswordExpired ";
            }
            if (vo.PasswordExpiredDate != null)
            {
                column += ", PasswordExpiredDate=@PasswordExpiredDate ";
            }
            if (vo.StartDate != null)
            {
                column += ", StartDate=@StartDate ";
            }
            if (vo.EndDate != null)
            {
                column += ", EndDate=@EndDate ";
            }
            if (vo.State != null)
            {
                column += ", State=@State ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update UserAccount set {column} where UserID=@UserID";

            return Excute(sql, vo);
        }
        public int Delete(UserAccount vo)
        {
            string condition = "";

            if (vo.UserID != null)
            {
                condition += "and UserID=@UserID ";
            }
            if (vo.Account != null)
            {
                condition += "and Account=@Account ";
            }
            if (vo.Password != null)
            {
                condition += "and Password=@Password ";
            }
            if (vo.ErrorCounts != null)
            {
                condition += "and ErrorCounts=@ErrorCounts ";
            }
            if (vo.IsPasswordExpired != null)
            {
                condition += "and IsPasswordExpired=@IsPasswordExpired ";
            }
            if (vo.PasswordExpiredDate != null)
            {
                condition += "and PasswordExpiredDate=@PasswordExpiredDate ";
            }
            if (vo.StartDate != null)
            {
                condition += "and StartDate=@StartDate ";
            }
            if (vo.EndDate != null)
            {
                condition += "and EndDate=@EndDate ";
            }
            if (vo.State != null)
            {
                condition += "and State=@State ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from UserAccount where {condition}";

            return Excute(sql, vo);
        }
    }
}
