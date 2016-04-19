using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class PictureManager
    {
        private PictureDAO pdao = null;
        public PictureManager()
        {
            pdao=new PictureDAO();
        }
        /// <summary>
        /// 插入图片
        /// </summary>
        /// <param name="p">图片实体类</param>
        /// <returns></returns>
        public bool Insert(Picture p)
        {
            return pdao.Insert(p);
        }

        /// <summary>
        /// 获取图片的存储地址
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string GetPictures(int num,string caId)
        {
            return pdao.GetPictures(num,caId);
        }

        /// <summary>
        /// 获取图片内容
        /// </summary>
        /// <param name="picnum">图片编号</param>
        /// <returns></returns>
        public string GetPicturesContent(int picnum,string caId)
        {
            return pdao.GetPicturesContent(picnum,caId);
        }

        /// <summary>
        /// 查找最新插入的5张新图片的地址
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string GetAllNewPictures(int num)
        {
            return pdao.GetAllNewPictures(num);
        }

        /// <summary>
        /// 查找最新插入的5张新图片的内容
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string GetAllNewPicturesContent(int num)
        {
            return pdao.GetAllPicturesContent(num);
        }
    }
}
