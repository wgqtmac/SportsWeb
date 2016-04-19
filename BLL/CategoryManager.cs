/*
 * 创建人：tmac
 * 创建时间：2014/6/1
 * 说明：新闻类别表的业务类
 * 版权所有：wgq7521244@126.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CategoryManager
    {
        private CategoryDAO cdao = null;
        public CategoryManager()
        {
            cdao = new CategoryDAO();
        }

        #region 取出当前所有新闻分类
        /// <summary>
        /// 取出当前所有新闻分类
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            return cdao.SelectAll();
        }
        #endregion

        #region 增加类别
        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Insert(string caName)
        {
            return cdao.Insert(caName);
        }
        #endregion

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool Update(Category ca)
        {
            return cdao.Update(ca);
        }
        #endregion

        #region 删除类别
        /// <summary>
        /// 删除类别（连同其下的新闻及新闻评论一起删除）
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return cdao.Delete(id);
        }
        #endregion

        #region 判断类别名称是否已存在
        /// <summary>
        /// 判断类别名称是否已存在
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public bool IsExists(string caName)
        {
            return cdao.IsExists(caName);
        }
        #endregion

        #region 根据类别Id查询类别名称
        /// <summary>
        /// 根据类别Id查询类别名称
        /// </summary>
        /// <param name="caId">类别Id</param>
        /// <returns>dt</returns>
        public DataTable SelectCaNameById(string caId)
        {
            return cdao.SelectCaNameById(caId);
        }
        #endregion

    }
}
