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
    public class commonSonDAO
    {
        private SQLHelper sqlhelper;
        public commonSonDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 通过sonId查询出所有commonSon
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public DataTable SelectCommonSonBySonId(string sonId)
        {
            DataTable dt = new DataTable();
            string cmdText = "commonSon_selectCommonSonBySonId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@sonId",sonId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据Id查询commonSon
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CommonSon SelectCommonSonById(string id)
        {
            CommonSon commonSon = new CommonSon();
            DataTable dt = new DataTable();
            string cmdText = "commonSon_selectById";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            commonSon.Title = dt.Rows[0]["title"].ToString();
            commonSon.Content = dt.Rows[0]["content"].ToString();
            commonSon.CreateTime = dt.Rows[0]["createTime"].ToString();
            commonSon.SonId = dt.Rows[0]["sonId"].ToString();
            return commonSon;
        }


        /// <summary>
        /// 查询出所有的commonSon
        /// </summary>
        /// <returns>dt</returns>
        public DataTable SelectAllCommonSon()
        {
            DataTable dt = new DataTable();
            string cmdText = "commonSon_selectAll";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 更新commonson
        /// </summary>
        /// <param name="commonson"></param>
        /// <returns></returns>
        public bool update(CommonSon commonson)
        {
            bool flag = false;
            string cmdText = "commonSon_update";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",commonson.Id),
                new SqlParameter("@title",commonson.Title),
                new SqlParameter("@content",commonson.Content)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        ///删除commonson 
        /// </summary>
        /// <param name="id">commonSon的Id</param>
        /// <returns>flag</returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "commonSon_delete";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@Id",id)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 添加commonSon
        /// </summary>
        /// <param name="commonSon">CommonSon实体类</param>
        /// <returns>flag</returns>
        public bool Insert(CommonSon commonSon)
        {
            bool flag = false;
            string cmdText = "commonSon_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@title",commonSon.Title),
                new SqlParameter("@content",commonSon.Content),
                new SqlParameter("@sonId",commonSon.SonId)
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
