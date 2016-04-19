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
    public class TeacherDAO
    {
        private SQLHelper sqlhelper;
        public TeacherDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 查询出所有的教师信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllTeacher()
        {
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery("tea_selectAllTeacher", CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据Id查询具体教师信息
        /// </summary>
        /// <param name="id">教师Id</param>
        /// <returns>dt</returns>
        public DataTable SelectTeacherById(string id)
        {
            DataTable dt = new DataTable();
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@teaId",id)
            };
            dt = sqlhelper.ExecuteQuery("tea_selectTeacherById", paras, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 插入教师信息
        /// </summary>
        /// <param name="teacher">教师实体类</param>
        /// <returns></returns>
        public bool Insert(Teacher teacher)
        {
            bool flag = false;
            string cmdText = "teacher_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@teaName",teacher.TeaName),
                new SqlParameter("@party",teacher.Party),
                new SqlParameter("@title",teacher.Title),
                new SqlParameter("@post",teacher.Post),
                new SqlParameter("@content",teacher.Content),
                new SqlParameter("@pic_path",teacher.PicPath)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="id">教师Id</param>
        /// <returns>flag</returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "teacher_delete";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@teaId",id)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 更新教师信息
        /// </summary>
        /// <param name="teacher">教师实体类</param>
        /// <returns>flag</returns>
        public bool Update(Teacher teacher)
        {
            bool flag = false;
            string cmdText = "teacher_update";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@teaId",teacher.TeaId),
                new SqlParameter("@teaName",teacher.TeaName),
                new SqlParameter("@party",teacher.Party),
                new SqlParameter("@title",teacher.Title),
                new SqlParameter("@post",teacher.Post),
                new SqlParameter("@content",teacher.Content),
                new SqlParameter("@pic_path",teacher.PicPath)
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
