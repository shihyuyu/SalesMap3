using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class SalesMapCommunityBO
    {
        private static SalesMapCommunityDAO DAO = new SalesMapCommunityDAO();

        public static SalesMapCommunity Get(int Id)
        {
            return DAO.Select(new SalesMapCommunity() { CommunityID = Id }).FirstOrDefault(new SalesMapCommunity());
        }
        public static List<SalesMapCommunity> GetList(SalesMapCommunity vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(SalesMapCommunity vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(SalesMapCommunity vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(SalesMapCommunity vo)
        {
            bool DataExisit = DAO.Select(new SalesMapCommunity() { CommunityID = vo.CommunityID }).Any();

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
            return DAO.Delete(new SalesMapCommunity() { CommunityID = Id }) == 1;
        }
    }
}
