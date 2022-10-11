using SalesMapLib.VO.BaseModels;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class UserInfoDAO : BaseDAO
    {
        public IEnumerable<UserInfo> Select(UserInfo vo)
        {
            string condition = "";

            if (vo.UserID != null)
            {
                condition += "and UserID=@UserID ";
            }
            if (vo.Name != null)
            {
                condition += "and Name=@Name ";
            }
            if (vo.ShowName != null)
            {
                condition += "and ShowName=@ShowName ";
            }
            if (vo.Birthday != null)
            {
                condition += "and Birthday=@Birthday ";
            }
            if (vo.Sex != null)
            {
                condition += "and Sex=@Sex ";
            }
            if (vo.Tel != null)
            {
                condition += "and Tel=@Tel ";
            }
            if (vo.Mobile != null)
            {
                condition += "and Mobile=@Mobile ";
            }
            if (vo.Email != null)
            {
                condition += "and Email=@Email ";
            }
            if (vo.LineID != null)
            {
                condition += "and LineID=@LineID ";
            }
            if (vo.Photo != null)
            {
                condition += "and Photo=@Photo ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from UserInfo where {condition} {{1}}";


            return Query<UserInfo>(sql, vo);
        }
        public int Insert(UserInfo vo)
        {
            string column = "";
            string parameter = "";

            if (vo.UserID != null)
            {
                column += ", UserID ";
                parameter += ", @UserID ";
            }
            if (vo.Name != null)
            {
                column += ", Name ";
                parameter += ", @Name ";
            }
            if (vo.ShowName != null)
            {
                column += ", ShowName ";
                parameter += ", @ShowName ";
            }
            if (vo.Birthday != null)
            {
                column += ", Birthday ";
                parameter += ", @Birthday ";
            }
            if (vo.Sex != null)
            {
                column += ", Sex ";
                parameter += ", @Sex ";
            }
            if (vo.Tel != null)
            {
                column += ", Tel ";
                parameter += ", @Tel ";
            }
            if (vo.Mobile != null)
            {
                column += ", Mobile ";
                parameter += ", @Mobile ";
            }
            if (vo.Email != null)
            {
                column += ", Email ";
                parameter += ", @Email ";
            }
            if (vo.LineID != null)
            {
                column += ", LineID ";
                parameter += ", @LineID ";
            }
            if (vo.Photo != null)
            {
                column += ", Photo ";
                parameter += ", @Photo ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into UserInfo( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(UserInfo vo)
        {
            string column = "";

            if (vo.UserID == null)
            {
                throw new Exception("PrimayKey欄位UserID不可為NULL");
            }
            if (vo.Name != null)
            {
                column += ", Name=@Name ";
            }
            if (vo.ShowName != null)
            {
                column += ", ShowName=@ShowName ";
            }
            if (vo.Birthday != null)
            {
                column += ", Birthday=@Birthday ";
            }
            if (vo.Sex != null)
            {
                column += ", Sex=@Sex ";
            }
            if (vo.Tel != null)
            {
                column += ", Tel=@Tel ";
            }
            if (vo.Mobile != null)
            {
                column += ", Mobile=@Mobile ";
            }
            if (vo.Email != null)
            {
                column += ", Email=@Email ";
            }
            if (vo.LineID != null)
            {
                column += ", LineID=@LineID ";
            }
            if (vo.Photo != null)
            {
                column += ", Photo=@Photo ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update UserInfo set {column} where UserID=@UserID";

            return Excute(sql, vo);
        }
        public int Delete(UserInfo vo)
        {
            string condition = "";

            if (vo.UserID != null)
            {
                condition += "and UserID=@UserID ";
            }
            if (vo.Name != null)
            {
                condition += "and Name=@Name ";
            }
            if (vo.ShowName != null)
            {
                condition += "and ShowName=@ShowName ";
            }
            if (vo.Birthday != null)
            {
                condition += "and Birthday=@Birthday ";
            }
            if (vo.Sex != null)
            {
                condition += "and Sex=@Sex ";
            }
            if (vo.Tel != null)
            {
                condition += "and Tel=@Tel ";
            }
            if (vo.Mobile != null)
            {
                condition += "and Mobile=@Mobile ";
            }
            if (vo.Email != null)
            {
                condition += "and Email=@Email ";
            }
            if (vo.LineID != null)
            {
                condition += "and LineID=@LineID ";
            }
            if (vo.Photo != null)
            {
                condition += "and Photo=@Photo ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from UserInfo where {condition}";

            return Excute(sql, vo);
        }
    }
}
