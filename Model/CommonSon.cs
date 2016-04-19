using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CommonSon
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
        /// 新闻标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string content;
        /// <summary>
        /// 新闻内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string createTime;
        /// <summary>
        /// 新闻发布时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private string sonId;
        /// <summary>
        /// 新闻所属类别ID
        /// </summary>
        public string SonId
        {
            get { return sonId; }
            set { sonId = value; }
        }

        public CommonSon(){ }

        public CommonSon(string title, string content, string sonId)
        {
            this.title = title;
            this.content = content;
            this.sonId = sonId;
        }
    }
}
