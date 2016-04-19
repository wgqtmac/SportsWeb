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
    public  class CommonDAO
    {
        private SQLHelper sqlhelper;
        public CommonDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 通过common的Id查找主题内容
        /// </summary>
        /// <param name="id">common的Id</param>
        /// <returns></returns>
        public Common SelectById(string id)
        {
            Common c = new Common();
            DataTable dt = new DataTable();
            string cmdText = "common_selectById";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            c.Id = id;
            c.Title = dt.Rows[0]["title"].ToString();
            c.Content = dt.Rows[0]["content"].ToString();
            c.CreateTime = dt.Rows[0]["createTime"].ToString();
            c.CaId = dt.Rows[0]["caId"].ToString();
            return c;
        }

        /// <summary>
        /// 根据类别Id取出该类别下的最新6条common
        /// </summary>
        /// <param name="CaId">类别Id</param>
        /// <returns></returns>
        public DataTable SelectNewNewsByCaId(string CaId)
        {
            DataTable dt = new DataTable();
            string cmdText = "common_selectNewNewsByCaId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@CaId",CaId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据类别Id取出该类别下的所有common
        /// </summary>
        /// <param name="caId">类别Id</param>
        /// <returns></returns>
        public DataTable SelectAllNewsByCaId(string caId)
        {
            DataTable dt = new DataTable();
            string cmdText = "common_selectAllNewsByCaId";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@caId",caId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }


        /// <summary>
        /// 取出所有的flag为1(没有二级菜单)的common
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllCommon()
        {
            DataTable dt = new DataTable();
            string cmdText = "common_selectAllCommon";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }


        /// <summary>
        /// 取出所有的栏目
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllCommonlist()
        {
            DataTable dt = new DataTable();
            string cmdText = "common_selectAllCommonlist";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 取出所有的flag为2(有二级菜单)的common
        /// </summary>
        /// <returns></returns>
        public DataTable SelectCommonHaveSon()
        {
            DataTable dt = new DataTable();
            string cmdText = "common_selectCommonHaveSon";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据common的Id查询出名称
        /// </summary>
        /// <param name="commonId"></param>
        /// <returns></returns>
        public DataTable SelectCommonNameById(string commonId)
        {
            DataTable dt = new DataTable();
            string cmdText = "common_SelectCommonNameById";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",commonId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 更新common
        /// </summary>
        /// <param name="common">common实体类</param>
        /// <returns></returns>
        public bool update(Common common)
        {
            bool flag = false;
            string cmdText = "common_update";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@id",common.Id),
                new SqlParameter("@title",common.Title),
                new SqlParameter("@content",common.Content)
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
