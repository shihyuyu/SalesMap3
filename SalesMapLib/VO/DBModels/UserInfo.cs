using SalesMapLib.VO.BaseModels;

namespace SalesMapLib.VO.DBModels
{
    public class UserInfo : Base
    {
        /// <summary>
        /// 使用者編號
        /// </summary>
        public string? UserID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 顯示名稱
        /// </summary>
        public string? ShowName { get; set; }
        /// <summary>
        /// 生日YYYYMMDD
        /// </summary>
        public string? Birthday { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public string? Sex { get; set; }
        /// <summary>
        /// 連絡電話
        /// </summary>
        public string? Tel { get; set; }
        /// <summary>
        /// 手機號碼
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// 電子郵件
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Line ID
        /// </summary>
        public string? LineID { get; set; }
        /// <summary>
        /// 照片(連結)
        /// </summary>
        public string? Photo { get; set; }
    }
}
