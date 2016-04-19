using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class File
    {
        private string dId;
        /// <summary>
        /// 主键，自增
        /// </summary>
        public string DId
        {
            get { return dId; }
            set { dId = value; }
        }
        private string dTitle;
        /// <summary>
        /// 文件标题
        /// </summary>
        public string DTitle
        {
            get { return dTitle; }
            set { dTitle = value; }
        }
        private string down_path;
        /// <summary>
        /// 文件路径
        /// </summary>
        public string Down_path
        {
            get { return down_path; }
            set { down_path = value; }
        }
        private string downId;
        /// <summary>
        /// 文件所属的CommonSon(二级菜单)
        /// </summary>
        public string DownId
        {
            get { return downId; }
            set { downId = value; }
        }
    }
}
