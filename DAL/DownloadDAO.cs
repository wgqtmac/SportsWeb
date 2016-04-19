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
    public class DownloadDAO
    {
        private SQLHelper sqlhelper = null;
        public DownloadDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 查找出所有的文件
        /// </summary>
        /// <returns>dt</returns>
        public DataTable SelectAllFile()
        {
            DataTable dt = new DataTable();
            string cmdText = "file_selectAllFile";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据commonSon(二级菜单)的类别Id查找所有文件
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public DataTable SelectAllFileBySonId(string sonId)
        {
            DataTable dt = new DataTable();
            string cmdText = "file_selectAllFileBySonId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@downId",sonId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据Id取得file主体内容
        /// </summary>
        /// <param name="id">file的id</param>
        /// <returns>file实体类</returns>
        public File SelectFileById(string id)
        {
            File file = new File();
            DataTable dt = new DataTable();
            string cmdText = "file_selectFileById";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@dId",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            file.DTitle = dt.Rows[0]["dTitle"].ToString();
            file.Down_path = dt.Rows[0]["down_path"].ToString();
            file.DownId = dt.Rows[0]["downId"].ToString();
            return file;
        }

        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="file">文件实体类</param>
        /// <returns></returns>
        public bool Insert(File file)
        {
            bool flag = false;
            string cmdText = "file_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@dTitle",file.DTitle),
                new SqlParameter("@down_path",file.Down_path),
                new SqlParameter("@downId",file.DownId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="id">文件Id</param>
        /// <returns>flag</returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "file_delete";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@dId",id)
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
