using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Picture
    {
        private string id;
        /// <summary>
        /// 主键，自增
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;
        /// <summary>
        /// 图片标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string content;
        /// <summary>
        /// 图片内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string paths;
        /// <summary>
        /// 图片路径
        /// </summary>
        public string Paths
        {
            get { return paths; }
            set { paths = value; }
        }
        private string createTime;
        /// <summary>
        /// 发布图片时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string caId;
        /// <summary>
        /// 图片所属类别ID
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }

        public Picture() { }

        public Picture(string title, string content, string paths, string caId)
        {
            this.title = title;
            this.content = content;
            this.caId = caId;
            this.paths = paths;
        }
    }
}
