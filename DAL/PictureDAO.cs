/*
 * 创建人：tmac
 * 创建时间：2014/6/16
 * 说明：新闻类别表操作类
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

    public class PictureDAO
    {
        private SQLHelper sqlhelper;
        public PictureDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 增加图片
        /// </summary>
        /// <param name="p">图片实体类</param>
        /// <returns></returns>
        public bool Insert(Picture p)
        {
            //TODO:增加新闻
            bool flag = false;
            string cmdText = "pic_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@title",p.Title),
                new SqlParameter("@content",p.Content),
                new SqlParameter("@paths",p.Paths),
                new SqlParameter("@caId",p.CaId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }


        /// <summary>
        /// 获取图片的存储地址
        /// </summary>
        /// <param name="picnum">图片的编号</param>
        /// <returns></returns>
        public string GetPictures(int picnum, string caId)
        {
            string cmdText = "pictures_selectNewPicture";
            DataTable dt = new DataTable();
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@caId",caId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            string strpaths = dt.Rows[picnum]["paths"].ToString();
            return strpaths;
        }

        /// <summary>
        /// 获取图片内容
        /// </summary>
        /// <param name="picnum">图片编号</param>
        /// <returns></returns>
        public string GetPicturesContent(int picnum, string caId)
        {
            string cmdText = "pictures_selectNewPicture";
            DataTable dt = new DataTable();
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@caId",caId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            string content = dt.Rows[picnum]["content"].ToString();
            return content;
        }

        /// <summary>
        /// 查找最新插入的5张新图片地址
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string GetAllNewPictures(int num)
        {
            string cmdText = "Pic_selectAllNewPic";
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            string strpaths = dt.Rows[num]["paths"].ToString();
            return strpaths;
        }

        /// <summary>
        /// 查找最新插入的5张新图片的内容
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string GetAllPicturesContent(int num)
        {
            string cmdText = "Pic_selectAllNewPic";
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            string content = dt.Rows[num]["content"].ToString();
            return content;
        }
    }
}
