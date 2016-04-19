using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class CommonManager
    {
        private CommonDAO cdao = null;
        public CommonManager()
        {
            cdao = new CommonDAO();
        }
        /// <summary>
        /// 根据common的Id取出主题内容
        /// </summary>
        /// <param name="id">common的Id</param>
        /// <returns></returns>
        public Common SelectById(string id)
        {
            return cdao.SelectById(id);
        }

        /// <summary>
        /// 根据类别Id取出该类别下的6条Common
        /// </summary>
        /// <param name="CaId">类别Id</param>
        /// <returns></returns>
        public DataTable SelectNewNewsByCaId(string CaId)
        {
            return cdao.SelectNewNewsByCaId(CaId);
        }

        /// <summary>
        /// 根据类别Id取出该类别下的所有common
        /// </summary>
        /// <param name="caId">类别Id</param>
        /// <returns></returns>
        public DataTable SelectAllNewsByCaId(string caId)
        {
            return cdao.SelectAllNewsByCaId(caId);
        }

        /// <summary>
        /// 取出所有没有二级菜单的common
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllCommon()
        {
            return cdao.SelectAllCommon();
        }

        /// <summary>
        /// 取出所有的栏目（common）
        /// </summary>
        /// <returns></returns>
        public DataTable SelectCommonlist()
        {
            return cdao.SelectAllCommonlist();

        }

        /// <summary>
        /// 取出所有有二级菜单的common
        /// </summary>
        /// <returns></returns>
        public DataTable SelectCommonHaveSon()
        {
            return cdao.SelectCommonHaveSon();
        }


        /// <summary>
        /// 根据common的Id查询出名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable SelectCommonNameById(string id)
        {
            return cdao.SelectCommonNameById(id);
        }

        /// <summary>
        /// 更新common
        /// </summary>
        /// <param name="common">common实体类</param>
        /// <returns></returns>
        public bool Update(Common common)
        {
            return cdao.update(common);
        }
    }
}
