using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class SalesMapCustomerBO
    {
        private static SalesMapCustomerDAO DAO = new SalesMapCustomerDAO();

        public static SalesMapCustomer Get(string Id)
        {
            return DAO.Select(new SalesMapCustomer() { CustomerID = Id }).FirstOrDefault(new SalesMapCustomer());
        }
        public static List<SalesMapCustomer> GetList(SalesMapCustomer vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(SalesMapCustomer vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(SalesMapCustomer vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(SalesMapCustomer vo)
        {
            bool DataExisit = DAO.Select(new SalesMapCustomer() { CustomerID = vo.CustomerID }).Any();

            if (DataExisit)
            {
                return Update(vo);
            }
            else
            {
                return Insert(vo);
            }
        }
        public static bool Delete(string Id)
        {
            return DAO.Delete(new SalesMapCustomer() { CustomerID = Id }) == 1;
        }
    }
}
