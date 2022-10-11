namespace SalesMapLib.VO.BaseModels
{
    public class Base
    {
        /// <summary>
        /// 系統遮罩
        /// </summary>
        [SystemColumn]
        public int? Mask { get; set; }
        /// <summary>
        /// 建立者
        /// </summary>
        [SystemColumn]
        public string? CreateBy { get; set; }
        /// <summary>
        /// 修改者
        /// </summary>
        [SystemColumn]
        public string? ReviseBy { get; set; }
        /// <summary>
        /// 刪除者
        /// </summary>
        [SystemColumn]
        public string? DeleteBy { get; set; }
        /// <summary>
        /// 建立群組
        /// </summary>
        [SystemColumn]
        public string? CreateGrp { get; set; }
        /// <summary>
        /// 修改群組
        /// </summary>
        [SystemColumn]
        public string? ReviseGrp { get; set; }
        /// <summary>
        /// 刪除群駔
        /// </summary>
        [SystemColumn]
        public string? DeleteGrp { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        [SystemColumn]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 修改時間
        /// </summary>
        [SystemColumn]
        public DateTime? ReviseTime { get; set; }
        /// <summary>
        /// 刪除時間
        /// </summary>
        [SystemColumn]
        public DateTime? DeleteTime { get; set; }

    }
}
