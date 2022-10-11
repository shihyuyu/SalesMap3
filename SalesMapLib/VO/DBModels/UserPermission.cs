namespace SalesMapLib.VO.DBModels
{
    public class UserPermission
    {
        /// <summary>
        /// 系統編號
        /// </summary>
        public Guid? ID { get; set; }
        /// <summary>
        /// 使用者編號
        /// </summary>
        public string? UserId { get; set; }
        /// <summary>
        /// 功能編號
        /// </summary>
        public int? FunctionID { get; set; }
        /// <summary>
        /// 允許顯示
        /// </summary>
        public bool? Visible { get; set; }
    }
}
