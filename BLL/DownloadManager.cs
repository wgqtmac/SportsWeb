using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;

namespace BLL
{
    public class DownloadManager
    {
        private DownloadDAO ddao = null;
        public DownloadManager()
        {
            ddao=new DownloadDAO();
        }

        /// <summary>
        /// 查找所有的文件
        /// </summary>
        /// <returns>dt</returns>
        public DataTable SelectAllFile()
        {
            return ddao.SelectAllFile();
        }

        /// <summary>
        /// 根据commonson的Id查找所有文件
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public DataTable SelectAllFileBySonId(string sonId)
        {
            return ddao.SelectAllFileBySonId(sonId);
        }

        /// <summary>
        /// 根据Id取的file主题内容
        /// </summary>
        /// <param name="id">file的id</param>
        /// <returns>file实体类</returns>
        public File SelectFileById(string id)
        {
            return ddao.SelectFileById(id);
        }

        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="file">文件实体类</param>
        /// <returns></returns>
        public bool Insert(File file)
        {
            return ddao.Insert(file);
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="id">文件ID</param>
        /// <returns>flag</returns>
        public bool Delete(string id)
        {
            return ddao.Delete(id);
        }
    }
}
