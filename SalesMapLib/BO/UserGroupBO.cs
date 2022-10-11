using SalesMapLib.DAO;
using SalesMapLib.VO.BaseModels;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class UserGroupBO
    {
        private static UserGroupDAO DAO = new UserGroupDAO();

        public static UserGroup Get(string Id)
        {
            return DAO.Select(new UserGroup() { ID = new Guid(Id) }).FirstOrDefault(new UserGroup());
        }
        public static List<UserGroup> GetList(UserGroup vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(UserGroup vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(UserGroup vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(UserGroup vo)
        {
            bool DataExisit = DAO.Select(new UserGroup() { ID = vo.ID }).Any();

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
            return DAO.Delete(new UserGroup() { ID = new Guid(Id) }) == 1;
        }
    }
}
