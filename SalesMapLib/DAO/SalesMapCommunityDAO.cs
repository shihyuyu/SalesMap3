using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class SalesMapCommunityDAO : BaseDAO
    {
        public IEnumerable<SalesMapCommunity> Select(SalesMapCommunity vo)
        {
            string condition = "";

            if (vo.CommunityID != null)
            {
                condition += "and CommunityID=@CommunityID ";
            }
            if (vo.DomainID != null)
            {
                condition += "and DomainID=@DomainID ";
            }
            if (vo.FunctionID != null)
            {
                condition += "and FunctionID=@FunctionID ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from SalesMapCommunity where {condition} {{1}}";

            return Query<SalesMapCommunity>(sql, vo);
        }
        public int Insert(SalesMapCommunity vo)
        {
            string column = "";
            string parameter = "";

            if (vo.CommunityID != null)
            {
                column += ", CommunityID ";
                parameter += ", @CommunityID ";
            }
            if (vo.DomainID != null)
            {
                column += ", DomainID ";
                parameter += ", @DomainID ";
            }
            if (vo.FunctionID != null)
            {
                column += ", FunctionID ";
                parameter += ", @FunctionID ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into SalesMapCommunity( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(SalesMapCommunity vo)
        {
            string column = "";

            if (vo.CommunityID == null)
            {
                throw new Exception("PrimayKey欄位CommunityID不可為NULL");
            }
            if (vo.DomainID != null)
            {
                column += ", DomainID=@DomainID ";
            }
            if (vo.FunctionID != null)
            {
                column += ", FunctionID=@FunctionID ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update SalesMapCommunity set {column} where CommunityID=@CommunityID";

            return Excute(sql, vo);
        }
        public int Delete(SalesMapCommunity vo)
        {
            string condition = "";

            if (vo.CommunityID != null)
            {
                condition += "and CommunityID=@CommunityID ";
            }
            if (vo.DomainID != null)
            {
                condition += "and DomainID=@DomainID ";
            }
            if (vo.FunctionID != null)
            {
                condition += "and FunctionID=@FunctionID ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from SalesMapCommunity where {condition}";

            return Excute(sql, vo);
        }
    }
}
