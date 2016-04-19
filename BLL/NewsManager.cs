/*
 * 创建人：tmac
 * 创建时间：2014/6/1
 * 说明：新闻表的业务类
 * 版权所有：wgq7521244@126.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NewsManager
    {
        private NewsDAO ndao = null;
        public NewsManager()
        {
            ndao = new NewsDAO();
        }


        /// <summary>
        /// 取出所有新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllNews()
        {
            return ndao.SelectAllNews();
        }

        #region 选择最新十条新闻
        /// <summary>
        /// 取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            return ndao.SelectNewNews();
        }
        #endregion

        #region 选择10条热点新闻
        /// <summary>
        /// 取出10条热点新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotNews()
        {
            return ndao.SelectHotNews();
        }
        #endregion

        #region 通过类别ID选择新闻
        /// <summary>
        /// 根据类别ID取出该类别下的所有新闻
        /// </summary>
        /// <param name="caId">类别ID</param>
        /// <returns></returns>
        public DataTable SelectByCaId(string caId)
        {
            return ndao.SelectByCaId(caId);
        }
        #endregion

        #region 通过新闻ID查看新闻
        /// <summary>
        /// 根据新闻ID取出该条新闻的主体内容
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public News SelectById(string id)
        {
            return ndao.SelectById(id);
        }
        #endregion

        #region 通过标题查找新闻
        /// <summary>
        /// 根据标题搜素新闻
        /// </summary>
        /// <param name="title">新闻标题关键字</param>
        /// <returns></returns>
        public DataTable SelectByTitle(string title)
        {
            return ndao.SelectByTitle(title);
        }
        #endregion

        #region 通过内容查找新闻
        /// <summary>
        /// 根据内容搜素新闻 
        /// </summary>
        /// <param name="content">新闻内容关键字</param>
        /// <returns></returns>
        public DataTable SelectByContent(string content)
        {
            return ndao.SelectByContent(content);
        }
        #endregion

        #region 增加新闻
        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="n">新闻实体类</param>
        /// <returns></returns>
        public bool Insert(News n)
        {
            return ndao.Insert(n);
        }
        #endregion

        #region 修改新闻
        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="n">新闻实体类</param>
        /// <returns></returns>
        public bool Update(News n)
        {
            return ndao.Update(n);
        }
        #endregion

        #region 删除新闻
        /// <summary>
        /// 删除新闻(连同其下新闻评论一起删除)
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return ndao.Delete(id);
        }
        #endregion

        /// <summary>
        /// 根据类别Id取出给类别下的最新的6条新闻
        /// </summary>
        /// <param name="id">类别Id</param>
        /// <returns></returns>
        public DataTable SelectNewNewsByCaId(string id)
        {
            return ndao.SelectNewNewsByCaId(id);
        }

        /// <summary>
        /// 根据类别Id取出给类别下的最新的一条新闻
        /// </summary>
        /// <param name="id">类别Id</param>
        /// <returns></returns>
        public DataTable SelectOneNewsByCaId(string id)
        {
            return ndao.SelectOneNewsByCaId(id);
        }
    }
}
