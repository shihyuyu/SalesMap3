using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class CodeTypeDAO : BaseDAO
    {
        public IEnumerable<CodeType> Select(CodeType vo)
        {
            string condition = "";

            if (vo.CodeTypeID != null)
            {
                condition += "and CodeTypeID=@CodeTypeID ";
            }
            if (vo.CodeTypeName != null)
            {
                condition += "and CodeTypeName=@CodeTypeName ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from CodeType where {condition} {{1}}";

            return Query<CodeType>(sql, vo);
        }
        public int Insert(CodeType vo)
        {
            string column = "";
            string parameter = "";

            if (vo.CodeTypeID != null)
            {
                column += ", CodeTypeID ";
                parameter += ", @CodeTypeID ";
            }
            if (vo.CodeTypeName != null)
            {
                column += ", CodeTypeName ";
                parameter += ", @CodeTypeName ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into CodeType( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(CodeType vo)
        {
            string column = "";

            if (vo.CodeTypeID == null)
            {
                throw new Exception("PrimayKey欄位CodeID不可為NULL");
            }
            if (vo.CodeTypeName != null)
            {
                column += ", CodeTypeName=@CodeTypeName ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update CodeType set {column} where CodeTypeID=@CodeTypeID";

            return Excute(sql, vo);
        }
        public int Delete(CodeType vo)
        {
            string condition = "";

            if (vo.CodeTypeID != null)
            {
                condition += "and CodeTypeID=@CodeTypeID ";
            }
            if (vo.CodeTypeName != null)
            {
                condition += "and CodeTypeName=@CodeTypeName ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from CodeType where {condition}";

            return Excute(sql, vo);
        }
    }
}
