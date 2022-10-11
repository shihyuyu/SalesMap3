using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class SalesMapDomainBO
    {
        private static SalesMapDomainDAO DAO = new SalesMapDomainDAO();

        public static SalesMapDomain Get(int Id)
        {
            return DAO.Select(new SalesMapDomain() { DomainID = Id }).FirstOrDefault(new SalesMapDomain());
        }
        public static List<SalesMapDomain> GetList(SalesMapDomain vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(SalesMapDomain vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(SalesMapDomain vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(SalesMapDomain vo)
        {
            bool DataExisit = DAO.Select(new SalesMapDomain() { DomainID = vo.DomainID }).Any();

            if (DataExisit)
            {
                return Update(vo);
            }
            else
            {
                return Insert(vo);
            }
        }
        public static bool Delete(int Id)
        {
            return DAO.Delete(new SalesMapDomain() { DomainID = Id }) == 1;
        }
    }
}
