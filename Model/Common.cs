using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Common
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
        /// common标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string content;
        /// <summary>
        /// common内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string createTime;
        /// <summary>
        /// common发布时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string caId;
        /// <summary>
        /// 新闻所属类别ID
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }

        public Common() { }

        public Common(string title, string content, string caId)
        {
            this.title = title;
            this.content = content;
            this.caId = caId;
        }
    }
}
