using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class CodeFileDAO : BaseDAO
    {
        public IEnumerable<CodeFile> Select(CodeFile vo)
        {
            string condition = "";

            if (vo.CodeID != null)
            {
                condition += "and CodeID=@CodeID ";
            }
            if (vo.CodeTypeID != null)
            {
                condition += "and CodeTypeID=@CodeTypeID ";
            }
            if (vo.Desc != null)
            {
                condition += "and Desc=@Desc ";
            }
            if (vo.State != null)
            {
                condition += "and State=@State ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from CodeFile where {condition} {{1}}";


            return Query<CodeFile>(sql, vo);
        }
        public int Insert(CodeFile vo)
        {
            string column = "";
            string parameter = "";

            if (vo.CodeID != null)
            {
                column += ", CodeID ";
                parameter += ", @CodeID ";
            }
            if (vo.CodeTypeID != null)
            {
                column += ", CodeTypeID ";
                parameter += ", @CodeTypeID ";
            }
            if (vo.Desc != null)
            {
                column += ", Desc ";
                parameter += ", @Desc ";
            }
            if (vo.State != null)
            {
                column += ", State ";
                parameter += ", @State ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into CodeFile( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(CodeFile vo)
        {
            string column = "";

            if (vo.CodeID == null)
            {
                throw new Exception("PrimayKey欄位CodeID不可為NULL");
            }
            if (vo.CodeTypeID != null)
            {
                column += ", CodeTypeID=@CodeTypeID ";
            }
            if (vo.Desc != null)
            {
                column += ", Desc=@Desc ";
            }
            if (vo.State != null)
            {
                column += ", State=@State ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update CodeFile set {column} where CodeID=@CodeID";

            return Excute(sql, vo);
        }
        public int Delete(CodeFile vo)
        {
            string condition = "";

            if (vo.CodeID != null)
            {
                condition += "and CodeID=@CodeID ";
            }
            if (vo.CodeTypeID != null)
            {
                condition += "and CodeTypeID=@CodeTypeID ";
            }
            if (vo.Desc != null)
            {
                condition += "and Desc=@Desc ";
            }
            if (vo.State != null)
            {
                condition += "and State=@State ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from CodeFile where {condition}";

            return Excute(sql, vo);
        }
    }
}
