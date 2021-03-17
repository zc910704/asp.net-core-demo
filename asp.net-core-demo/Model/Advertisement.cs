using SqlSugar;
using System;

namespace Model
{
    public class Advertisement
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        /// <summary>
        /// 广告图片
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 广告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 广告链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public DateTime Createdate { get; set; } = DateTime.Now;
    }
}
