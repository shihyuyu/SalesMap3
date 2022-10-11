using SalesMapLib.VO.BaseModels;

namespace SalesMapLib.VO.DBModels
{
    public class SalesMapCustomer : Base
    {
        /// <summary>
        /// 客戶編號
        /// </summary>
        public string? CustomerID { get; set; }
        /// <summary>
        /// 客戶編號父節點
        /// </summary>
        public string? CustomerPID { get; set; }
        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string? CustomerName { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public string? State { get; set; }
    }
}
