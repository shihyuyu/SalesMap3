using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class SalesMapFunctionDAO : BaseDAO
    {
        public IEnumerable<SalesMapFunction> Select(SalesMapFunction vo)
        {
            string condition = "";

            if (vo.FunctionID != null)
            {
                condition += "and FunctionID=@FunctionID ";
            }
            if (vo.FunctionPID != null)
            {
                condition += "and FunctionPID=@FunctionPID ";
            }
            if (vo.FunctionName != null)
            {
                condition += "and FunctionName=@FunctionName ";
            }
            if (vo.Url != null)
            {
                condition += "and Url=@Url ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from SalesMapFunction where {condition} {{1}}";

            return Query<SalesMapFunction>(sql, vo);
        }
        public int Insert(SalesMapFunction vo)
        {
            string column = "";
            string parameter = "";

            if (vo.FunctionID != null)
            {
                column += ", FunctionID ";
                parameter += ", @FunctionID ";
            }
            if (vo.FunctionPID != null)
            {
                column += ", FunctionPID ";
                parameter += ", @FunctionPID ";
            }
            if (vo.FunctionName != null)
            {
                column += ", FunctionName ";
                parameter += ", @FunctionName ";
            }
            if (vo.Url != null)
            {
                column += ", Url ";
                parameter += ", @Url ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into SalesMapFunction( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(SalesMapFunction vo)
        {
            string column = "";

            if (vo.FunctionID == null)
            {
                throw new Exception("PrimayKey欄位FunctionID不可為NULL");
            }
            if (vo.FunctionPID != null)
            {
                column += ", FunctionPID=@FunctionPID ";
            }
            if (vo.FunctionName != null)
            {
                column += ", FunctionName=@FunctionName ";
            }
            if (vo.Url != null)
            {
                column += ", Url=@Url ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update SalesMapFunction set {column} where FunctionID=@FunctionID";

            return Excute(sql, vo);
        }
        public int Delete(SalesMapFunction vo)
        {
            string condition = "";

            if (vo.FunctionID != null)
            {
                condition += "and FunctionID=@FunctionID ";
            }
            if (vo.FunctionPID != null)
            {
                condition += "and FunctionPID=@FunctionPID ";
            }
            if (vo.FunctionName != null)
            {
                condition += "and FunctionName=@FunctionName ";
            }
            if (vo.Url != null)
            {
                condition += "and Url=@Url ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from SalesMapFunction where {condition}";

            return Excute(sql, vo);
        }
    }
}
