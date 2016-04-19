using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Video
    {
        private string vId;
        /// <summary>
        /// 视频ID
        /// </summary>
        public string VId
        {
            get { return vId; }
            set { vId = value; }
        }
        private string vTitle;
        /// <summary>
        /// 视频标题
        /// </summary>
        public string VTitle
        {
            get { return vTitle; }
            set { vTitle = value; }
        }
        private string vPath;
        /// <summary>
        /// 视频的地址代码
        /// </summary>
        public string VPath
        {
            get { return vPath; }
            set { vPath = value; }
        }
    }
}
