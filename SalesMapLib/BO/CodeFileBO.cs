using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class CodeFileBO
    {
        private static CodeFileDAO DAO = new CodeFileDAO();

        public static CodeFile Get(string Id)
        {
            return DAO.Select(new CodeFile() { CodeID = Id }).FirstOrDefault(new CodeFile());
        }
        public static List<CodeFile> GetList(CodeFile vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(CodeFile vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(CodeFile vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(CodeFile vo)
        {
            bool DataExisit = DAO.Select(new CodeFile() { CodeID = vo.CodeID }).Any();

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
            return DAO.Delete(new CodeFile() { CodeID = Id }) == 1;
        }
    }
}
