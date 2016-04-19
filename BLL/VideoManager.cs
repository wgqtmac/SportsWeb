using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;


namespace BLL
{
    public class VideoManager
    {
        private VideoDAO vdao = null;
        public VideoManager()
        {
            vdao = new VideoDAO();
        }

        /// <summary>
        /// 取出所有的视频信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllVideo()
        {
            return vdao.SelectAllVideo();
        }

        /// <summary>
        /// 根据视频Id取出该视频的内容
        /// </summary>
        /// <param name="id">视频Id</param>
        /// <returns></returns>
        public Video SelectVideoById(string id)
        {
            return vdao.SelectVideoById(id);
        }


        /// <summary>
        /// 去除最新的5条视频信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectNewVideo()
        {
            return vdao.SelectNewVideo();
        }

        /// <summary>
        /// 插入视频
        /// </summary>
        /// <param name="video">视频实体类</param>
        /// <returns></returns>
        public bool Insert(Video video)
        {
            return vdao.Insert(video);
        }

        /// <summary>
        /// 删除视频
        /// </summary>
        /// <param name="id">视频Id</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return vdao.Delete(id);
        }
    }
}
