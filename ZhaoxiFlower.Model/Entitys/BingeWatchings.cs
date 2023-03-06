using SqlSugar;

namespace ZhaoxiFlower.Model.Entitys
{
    public class BingeWatchings
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }


        [SugarColumn(IsNullable = false)]
        public string Title { get; set; }


        [SugarColumn(IsNullable = false)]
        public string SubTitle { get; set; }


        [SugarColumn(IsNullable = false)]
        public string pic { get; set; }
        /// <summary>
        /// 追剧进度
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string  BingeWatching{ get; set; }
    }
}
