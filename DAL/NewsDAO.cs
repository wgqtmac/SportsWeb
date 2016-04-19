/*
 * 创建人：tmac
 * 创建时间：2014/6/16
 * 说明：新闻表操作类
 * 版权所有：wgq7521244@126.com
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class NewsDAO
    {
        private SQLHelper sqlhelper;
        public NewsDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 根据Id降序取出所有新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllNews()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("news_selectAllNews",CommandType.StoredProcedure);
            return dt;
        }

        #region 选择最新十条新闻
        /// <summary>
        /// 取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewNews()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("news_selectNewNews", CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        #region 选择10条热点新闻
        /// <summary>
        /// 取出10条热点新闻
        /// </summary>
        /// <returns></returns>
        public DataTable SelectHotNews()
        {
            //TODO:取出10条热点新闻
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("news_selectHotNews", CommandType.StoredProcedure);
            return dt;
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
            //TODO:根据类别ID取出该类别下的所有新闻
            DataTable dt = new DataTable();
            string cmdText = "news_selectByCaId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@caId",caId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
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
            //TODO:根据新闻ID取出该条新闻的主体内容
            News n = new News();
            DataTable dt = new DataTable();
            string cmdText = "news_selectById";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            n.Id = id;
            n.Title = dt.Rows[0]["title"].ToString();
            n.Content = dt.Rows[0]["content"].ToString();
            n.CreateTime = dt.Rows[0]["createTime"].ToString();
            n.CaId = dt.Rows[0]["caId"].ToString();
            return n;
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
            //TODO:根据标题搜素新闻
            DataTable dt = new DataTable();
            string cmdText = "news_selectByTitle";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@title",title)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
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
            //TODO:根据内容搜素新闻
            DataTable dt = new DataTable();
            string cmdText = "news_selectByContent";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@content",content)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
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
            //TODO:增加新闻
            bool flag = false;
            string cmdText = "news_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@title",n.Title),
                new SqlParameter("@content",n.Content),
                new SqlParameter("@caId",n.CaId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
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
            //TODO:修改新闻
            bool flag = false;
            string cmdText = "news_update";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",n.Id),
                new SqlParameter("@title",n.Title),
                new SqlParameter("@content",n.Content),
                new SqlParameter("@caId",n.CaId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
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
            //TODO:删除新闻
            bool flag = false;
            string cmdText = "news_delete";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 根据类别Id取出该类别下最新的6条新闻
        /// <summary>
        /// 根据类别Id取出该类别下最新的6条新闻
        /// </summary>
        /// <param name="CaId"></param>
        /// <returns></returns>
        public DataTable SelectNewNewsByCaId(string CaId)
        {
            DataTable dt = new DataTable();
            string cmdText="news_selectNewNewsByCaId";
            SqlParameter[] paras=new SqlParameter[]{
                new SqlParameter("@CaId",CaId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
        #endregion

        /// <summary>
        /// 根据类别Id取出给类别下的最新的一条新闻
        /// </summary>
        /// <param name="caId">类别Id</param>
        /// <returns></returns>
        public DataTable SelectOneNewsByCaId(string caId)
        {
            DataTable dt = new DataTable();
            string cmdText = "news_selectOneNewsByCaId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@CaId",caId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }
      

    }
}
