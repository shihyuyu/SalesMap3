using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class CodeTypeBO
    {
        private static CodeTypeDAO DAO = new CodeTypeDAO();

        public static CodeType Get(string Id)
        {
            return DAO.Select(new CodeType() { CodeTypeID = Id }).FirstOrDefault(new CodeType());
        }
        public static List<CodeType> GetList(CodeType vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(CodeType vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(CodeType vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(CodeType vo)
        {
            bool DataExisit = DAO.Select(new CodeType() { CodeTypeID = vo.CodeTypeID }).Any();

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
            return DAO.Delete(new CodeType() { CodeTypeID = Id }) == 1;
        }
    }
}
