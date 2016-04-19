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
    public class VenueManager
    {
        private VenueDAO vdao = null;

        public VenueManager()
        {
            vdao=new VenueDAO();
        }

        /// <summary>
        /// 查询出所有的场地信息
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllVenue()
        {
            return vdao.SelectAllVenue();
        }

        /// <summary>
        /// 根据venueId查询出最新的一张图片
        /// </summary>
        /// <param name="venueId"></param>
        /// <returns></returns>
        public DataTable SelectNewOnePic(string venueId)
        {
            return vdao.SelectNewOnePic(venueId);
        }

        /// <summary>
        /// 根据venueId查询出所有的图片
        /// </summary>
        /// <param name="venueId"></param>
        /// <returns></returns>
        public DataTable SelectAllPicByVenueId(string venueId)
        {
            return vdao.SelectAllPicByVenueId(venueId);
        }

        /// <summary>
        /// 根据Id查询场地信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Venue SelectVenueById(string id)
        {
            return vdao.SelectVenueById(id);
        }

        /// <summary>
        /// 增加场地信息
        /// </summary>
        /// <param name="venue"></param>
        /// <returns></returns>
        public bool Insert(Venue venue)
        {
            return vdao.Insert(venue);
        }

        /// <summary>
        /// 根据Id删除场地信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            return vdao.Delete(id);
        }
    }
}
