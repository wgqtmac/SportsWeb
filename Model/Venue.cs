using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venue
    {
        private string vId;
        /// <summary>
        /// 场地Id
        /// </summary>
        public string VId
        {
            get { return vId; }
            set { vId = value; }
        }
        private string vName;
        /// <summary>
        /// 场地标题
        /// </summary>
        public string VName
        {
            get { return vName; }
            set { vName = value; }
        }
        private string vContent;
        /// <summary>
        /// 场地内容
        /// </summary>
        public string VContent
        {
            get { return vContent; }
            set { vContent = value; }
        }
        private string vPath;
        /// <summary>
        /// 场地图片地址
        /// </summary>
        public string VPath
        {
            get { return vPath; }
            set { vPath = value; }
        }
        private string venueId;
        /// <summary>
        /// commonSon的Id（外键）
        /// </summary>
        public string VenueId
        {
            get { return venueId; }
            set { venueId = value; }
        }
    }
}
