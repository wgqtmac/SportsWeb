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
    public class VenueDAO
    {
        private SQLHelper sqlhelper = null;
        public VenueDAO()
        {
            sqlhelper = new SQLHelper();
        }

        /// <summary>
        /// 查询出所有的场地信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllVenue()
        {
            string cmdText = "venue_selectAllVenue";
            DataTable dt = new DataTable();
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 根据venueId查询出最新的一张图片
        /// </summary>
        /// <param name="venueId"></param>
        /// <returns></returns>
        public DataTable SelectNewOnePic(string venueId)
        {
            string cmdText = "venue_selectNewOnePic";
            DataTable dt = new DataTable();
            SqlParameter[] paras=new SqlParameter[]{
                new SqlParameter("@venueId",venueId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }


        /// <summary>
        /// 根据venueId查询出所有的图片
        /// </summary>
        /// <param name="venueId"></param>
        /// <returns></returns>
        public DataTable SelectAllPicByVenueId(string venueId)
        {
            string cmdText = "venue_selectAllPicByVenueId";
            DataTable dt = new DataTable();
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@venueId",venueId)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            return dt;
        }


        /// <summary>
        /// 根据Id查询出venue信息
        /// </summary>
        /// <param name="id">venue的Id</param>
        /// <returns></returns>
        public Venue SelectVenueById(string id)
        {
            Venue venue=new Venue();
            string cmdText = "venue_selectVenueById";
            DataTable dt = new DataTable();
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@pId",id)
            };
            dt = sqlhelper.ExecuteQuery(cmdText, paras, CommandType.StoredProcedure);
            venue.VName=dt.Rows[0]["pName"].ToString();
            venue.VPath=dt.Rows[0]["pic_path"].ToString();
            venue.VenueId=dt.Rows[0]["venueId"].ToString();
            return venue;
        }

        /// <summary>
        /// 增加场地信息
        /// </summary>
        /// <param name="venue">venue实体类</param>
        /// <returns></returns>
        public bool Insert(Venue venue)
        {
            bool flag = false;
            string cmdText = "venue_insert";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@vName",venue.VName),
                new SqlParameter("@vContent",venue.VContent),
                new SqlParameter("@vPath",venue.VPath),
                new SqlParameter("@venueId",venue.VenueId)
            };
            int res = sqlhelper.ExecuteNonQuery(cmdText, paras, CommandType.StoredProcedure);
            if (res > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 根据Id删除场地信息
        /// </summary>
        /// <param name="id">场地Id</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool flag = false;
            string cmdText = "venue_delete";
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@vId",id)
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
