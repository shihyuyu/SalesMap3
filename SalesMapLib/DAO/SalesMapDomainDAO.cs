using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class SalesMapDomainDAO : BaseDAO
    {
        public IEnumerable<SalesMapDomain> Select(SalesMapDomain vo)
        {
            string condition = "";

            if (vo.DomainID != null)
            {
                condition += "and DomainID=@DomainID ";
            }
            if (vo.DomainName != null)
            {
                condition += "and DomainName=@DomainName ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from SalesMapDomain where {condition} {{1}}";


            return Query<SalesMapDomain>(sql, vo);
        }
        public int Insert(SalesMapDomain vo)
        {
            string column = "";
            string parameter = "";

            if (vo.DomainID != null)
            {
                column += ", DomainID ";
                parameter += ", @DomainID ";
            }
            if (vo.DomainName != null)
            {
                column += ", DomainName ";
                parameter += ", @DomainName ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into SalesMapDomain( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(SalesMapDomain vo)
        {
            string column = "";

            if (vo.DomainID == null)
            {
                throw new Exception("PrimayKey欄位DomainID不可為NULL");
            }
            if (vo.DomainName != null)
            {
                column += ", DomainName=@DomainName ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update SalesMapDomain set {column} where DomainID=@DomainID";

            return Excute(sql, vo);
        }
        public int Delete(SalesMapDomain vo)
        {
            string condition = "";

            if (vo.DomainID != null)
            {
                condition += "and DomainID=@DomainID ";
            }
            if (vo.DomainName != null)
            {
                condition += "and DomainName=@DomainName ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from SalesMapDomain where {condition}";

            return Excute(sql, vo);
        }
    }
}
