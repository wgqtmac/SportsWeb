/*
 * 创建人：tmac
 * 创建时间：2014/5/30
 * 说明：新闻实体类
 * 版权所有：wgq7521244@126.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class News
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
        private string caId;
        /// <summary>
        /// 新闻所属类别ID
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }

        public News() { }

        public News(string title, string content, string caId)
        {
            this.title = title;
            this.content = content;
            this.caId = caId;
        }
    }
}
