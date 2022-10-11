using SalesMapLib.DAO;
using SalesMapLib.VO.DBModels;

namespace SalesMapLib.BO
{
    public class SalesMapFunctionBO
    {
        private static SalesMapFunctionDAO DAO = new SalesMapFunctionDAO();

        public static SalesMapFunction Get(int Id)
        {
            return DAO.Select(new SalesMapFunction() {  FunctionID = Id }).FirstOrDefault(new SalesMapFunction());
        }
        public static List<SalesMapFunction> GetList(SalesMapFunction vo)
        {
            return DAO.Select(vo).ToList();
        }

        public static bool Insert(SalesMapFunction vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Update(SalesMapFunction vo)
        {
            return DAO.Insert(vo) == 1;
        }
        public static bool Save(SalesMapFunction vo)
        {
            bool DataExisit = DAO.Select(new SalesMapFunction() { FunctionID = vo.FunctionID }).Any();

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
            return DAO.Delete(new SalesMapFunction() { FunctionID = Id }) == 1;
        }
    }
}
