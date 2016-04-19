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
    public class TeacherManager
    {
        private TeacherDAO tdao = null;
        public TeacherManager()
        {
            tdao=new TeacherDAO();
        }

        /// <summary>
        /// 取出所有教师信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllTeacher()
        {
            return tdao.SelectAllTeacher();
        }

        /// <summary>
        /// 根据Id查询教师具体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable SelectTeacherById(string id)
        {
            return tdao.SelectTeacherById(id);
        }

        /// <summary>
        /// 插入教师信息
        /// </summary>
        /// <param name="teacher">教师实体类</param>
        /// <returns></returns>
        public bool Insert(Teacher teacher)
        {
            return tdao.Insert(teacher);
        }

        /// <summary>
        /// 更新教师信息
        /// </summary>
        /// <param name="teacher">教师实体类</param>
        /// <returns>flag</returns>
        public bool Update(Teacher teacher)
        {
            return tdao.Update(teacher);
        }

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="id">教师id</param>
        /// <returns>flag</returns>
        public bool Delete(string id)
        {
            return tdao.Delete(id);
        }
    }
}
