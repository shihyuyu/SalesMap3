using SalesMapLib.VO.DBModels;

namespace SalesMapLib.DAO
{
    public class SalesMapCustomerDAO : BaseDAO
    {
        public IEnumerable<SalesMapCustomer> Select(SalesMapCustomer vo)
        {
            string condition = "";

            if (vo.CustomerID != null)
            {
                condition += "and CustomerID=@CustomerID ";
            }
            if (vo.CustomerPID != null)
            {
                condition += "and CustomerPID=@CustomerPID ";
            }
            if (vo.CustomerName != null)
            {
                condition += "and CustomerName=@CustomerName ";
            }
            if (vo.State != null)
            {
                condition += "and State=@State ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"select * {{0}} from SalesMapCustomer where {condition} {{1}}";


            return Query<SalesMapCustomer>(sql, vo);
        }
        public int Insert(SalesMapCustomer vo)
        {
            string column = "";
            string parameter = "";

            if (vo.CustomerID != null)
            {
                column += ", CustomerID ";
                parameter += ", @CustomerID ";
            }
            if (vo.CustomerPID != null)
            {
                column += ", CustomerPID ";
                parameter += ", @CustomerPID ";
            }
            if (vo.CustomerName != null)
            {
                column += ", CustomerName ";
                parameter += ", @CustomerName ";
            }
            if (vo.State != null)
            {
                column += ", State ";
                parameter += ", @State ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;
            parameter = (parameter.Length > 0) ? parameter.Substring(1) : parameter;

            string sql = $"insert into SalesMapCustomer( {column} ) values( {parameter} )";

            return Excute(sql, vo);
        }
        public int Update(SalesMapCustomer vo)
        {
            string column = "";

            if (vo.CustomerID == null)
            {
                throw new Exception("PrimayKey欄位CustomerID不可為NULL");
            }
            if (vo.CustomerPID != null)
            {
                column += ", CustomerPID=@CustomerPID ";
            }
            if (vo.CustomerName != null)
            {
                column += ", CustomerName=@CustomerName ";
            }
            if (vo.State != null)
            {
                column += ", State=@State ";
            }

            column = (column.Length > 0) ? column.Substring(1) : column;

            string sql = $"update SalesMapCustomer set {column} where CustomerID=@CustomerID";

            return Excute(sql, vo);
        }
        public int Delete(SalesMapCustomer vo)
        {
            string condition = "";

            if (vo.CustomerID != null)
            {
                condition += "and CustomerID=@CustomerID ";
            }
            if (vo.CustomerPID != null)
            {
                condition += "and CustomerPID=@CustomerPID ";
            }
            if (vo.CustomerName != null)
            {
                condition += "and CustomerName=@CustomerName ";
            }
            if (vo.State != null)
            {
                condition += "and State=@State ";
            }

            condition = (condition.Length > 0) ? condition.Substring(3) : condition;

            string sql = $"delete from SalesMapCustomer where {condition}";

            return Excute(sql, vo);
        }
    }
}
