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
    public class commonSonManager
    {
        private commonSonDAO csdao = null;
        public commonSonManager()
        {
            csdao=new commonSonDAO();
        }

        /// <summary>
        /// 根据sonId查询出所属commonSon
        /// </summary>
        /// <param name="sonId"></param>
        /// <returns></returns>
        public DataTable SelectCommonSonBySonId(string sonId)
        {
            return csdao.SelectCommonSonBySonId(sonId);
        }



        /// <summary>
        /// 根据Id查询commonSon
        /// </summary>
        /// <param name="id">commonSon的Id</param>
        /// <returns></returns>
        public CommonSon SelectCommonSonById(string id)
        {
            return csdao.SelectCommonSonById(id);
        }

        /// <summary>
        /// 查询出所有的commonSon
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllCommonSon()
        {
            return csdao.SelectAllCommonSon();
        }

        /// <summary>
        /// 更新CommonSon的信息
        /// </summary>
        /// <param name="commonSon">CommonSon实体类</param>
        /// <returns></returns>
        public bool Update(CommonSon commonSon)
        {
            return csdao.update(commonSon);
        }

        /// <summary>
        /// 删除CommonSon
        /// </summary>
        /// <param name="id">commonSon实体类</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return csdao.Delete(id);
        }

        /// <summary>
        /// 添加CommonSon
        /// </summary>
        /// <param name="commonSon">CommonSon实体类</param>
        /// <returns></returns>
        public bool Insert(CommonSon commonSon)
        {
            return csdao.Insert(commonSon);
        }
    }
}
