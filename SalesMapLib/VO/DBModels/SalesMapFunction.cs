namespace SalesMapLib.VO.DBModels
{
    public class SalesMapFunction
    {
        /// <summary>
        /// 功能編號
        /// </summary>
        public int? FunctionID { get; set; }
        /// <summary>
        /// 功能編號父節點
        /// </summary>
        public int? FunctionPID { get; set; }
        /// <summary>
        /// 功能名稱
        /// </summary>
        public string? FunctionName { get; set; }
        /// <summary>
        /// 路徑
        /// </summary>
        public string? Url { get; set; }
    }
}
