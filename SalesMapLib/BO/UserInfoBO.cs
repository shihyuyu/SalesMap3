using SalesMapLib.DAO;
using SalesMapLib.VO.BaseModels;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class UserInfoBO
    {
        private static UserInfoDAO DAO = new UserInfoDAO();

        public static UserInfo Get(string Id)
        {
            return DAO.Select(new UserInfo() { UserID = Id }).FirstOrDefault(new UserInfo());
        }
        public static List<UserInfo> GetList(UserInfo vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(UserInfo vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(UserInfo vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(UserInfo vo)
        {
            bool DataExisit = DAO.Select(new UserInfo() { UserID = vo.UserID }).Any();

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
            return DAO.Delete(new UserInfo() { UserID = Id }) == 1;
        }

    }
}
