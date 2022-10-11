using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class UserAccountBO
    {
        private static UserAccountDAO DAO = new UserAccountDAO();

        public static UserAccount Get(string Id)
        {
            return DAO.Select(new UserAccount() { UserID = Id }).FirstOrDefault(new UserAccount());
        }
        public static List<UserAccount> GetList(UserAccount vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(UserAccount vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(UserAccount vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(UserAccount vo)
        {
            bool DataExisit = DAO.Select(new UserAccount() { UserID = vo.UserID }).Any();

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
            return DAO.Delete(new UserAccount() { UserID = Id }) == 1;
        }
    }
}
