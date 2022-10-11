using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class UserPermissionBO
    {
        private static UserPermissionDAO DAO = new UserPermissionDAO();

        public static UserPermission Get(string Id)
        {
            return DAO.Select(new UserPermission() { ID = new Guid(Id) }).FirstOrDefault(new UserPermission());
        }
        public static List<UserPermission> GetList(UserPermission vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(UserPermission vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(UserPermission vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(UserPermission vo)
        {
            bool DataExisit = DAO.Select(new UserPermission() { ID = vo.ID }).Any();

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
            return DAO.Delete(new UserPermission() { ID = new Guid(Id) }) == 1;
        }
    }
}
