using SalesMapLib.VO.BaseModels;

namespace SalesMapLib.VO.DBModels
{
    public class UserGroup : Base
    {
        /// <summary>
        /// 系統編號(GUID)
        /// </summary>
        public Guid? ID { get; set; }
        /// <summary>
        /// 使用者編號
        /// </summary>
        public string? UserID { get; set; }
        /// <summary>
        /// 客戶編號
        /// SalesMapCustomer.CustomerID=UserGroup.CustomerID
        /// </summary>
        public string? CustomerID { get; set; }
        /// <summary>
        /// 角色等級
        /// </summary>
        public int? RoleLevel { get; set; }
    }
}
