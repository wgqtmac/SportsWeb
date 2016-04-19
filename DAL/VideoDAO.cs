using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class VideoDAO
    {
        private SQLHelper sqlhelper;
        public VideoDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 查询出所有的视频信息
        /// </summary>
        /// <returns>dt</returns>
        public DataTable SelectAllVideo()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("video_selectAllVideo", CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 取出最新的5条视频信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewVideo()
        {
            DataTable dt = new DataTable();
            string cmdText = "video_selectNewVideo";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据视频Id取出给视频的内容
        /// </summary>
        /// <param name="id">视频Id</param>
        /// <returns></returns>
        public Video SelectVideoById(string id)
        {
            Video video = new Video();
            DataTable dt = new DataTable();
            string cmdText = "video_selectById";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@vId",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            video.VId = id;
            video.VTitle = dt.Rows[0]["vTitle"].ToString();
            video.VPath = dt.Rows[0]["vPath"].ToString();
            return video;
        }

        /// <summary>
        /// 插入视频信息
        /// </summary>
        /// <param name="video">视频实体类</param>
        /// <returns>flag</returns>
        public bool Insert(Video video)
        {
            bool flag = false;
            string cmdText = "video_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@vTitle",video.VTitle),
                new SqlParameter("@vPath",video.VPath)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 删除视频信息
        /// </summary>
        /// <param name="id">视频Id</param>
        /// <returns>flag</returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "delete_video";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@vId",id)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}
