using SalesMapLib.VO.BaseModels;

namespace SalesMapLib.VO.DBModels
{
    public class UserAccount : Base
    {
        /// <summary>
        /// 使用者編號
        /// </summary>
        public string? UserID { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string? Account { get; set; }  
        /// <summary>
        /// 密碼
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// 錯誤次數
        /// </summary>
        public int? ErrorCounts { get; set; }
        /// <summary>
        /// 密碼過期
        /// </summary>
        public bool? IsPasswordExpired { get; set; }
        /// <summary>
        /// 密碼變更日YYYYMMDD
        /// </summary>
        public string? PasswordExpiredDate { get; set; }
        /// <summary>
        /// 啟用日YYYYMMDD
        /// </summary>
        public string? StartDate { get; set; }
        /// <summary>
        /// 停用日YYYYMMDD
        /// </summary>
        public string? EndDate { get; set; }
        /// <summary>
        /// 狀態
        /// </summary>
        public string? State { get; set; }
    }
}
