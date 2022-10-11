namespace SalesMapLib.VO.DBModels
{
    public class CodeFile
    {
        /// <summary>
        /// 代碼編號
        /// </summary>
        public string? CodeID { get; set; }
        /// <summary>
        /// 代碼類別編號
        /// </summary>
        public string? CodeTypeID { get; set; }
        /// <summary>
        /// 代碼描述
        /// </summary>
        public string? Desc { get; set; }
        /// <summary>
        /// 代碼狀態
        /// </summary>
        public string? State { get; set; }
    }
}
