using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using DAL;

namespace TheSportsWeb
{
    public partial class index : System.Web.UI.Page
    {
        NewsManager newsmanager = new NewsManager();
        PictureManager picmanager = new PictureManager();
        VideoManager videomanager = new VideoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            NewList();
        }
        /// <summary>
        /// 获取类别获取Id图片地址
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string PicList(int num, string caId)
        {
            return picmanager.GetPictures(num, caId);
        }
        /// <summary>
        /// 获取图片内容
        /// </summary>
        /// <param name="num">图片编号</param>
        /// <returns></returns>
        public string PicContentList(int num, string caId)
        {
            return picmanager.GetPicturesContent(num, caId);
        }

        /// <summary>
        /// 获取最新上传的5张图片地址
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string picAllList(int num)
        {
            return picmanager.GetAllNewPictures(num);
        }

        /// <summary>
        /// 获取最新上传的5张图片的内容
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string picAllContent(int num)
        {
            return picmanager.GetAllNewPicturesContent(num);
        }


        public string newNewsTitle()
        {
            string id = "1";
            DataTable dt = newsmanager.SelectOneNewsByCaId(id);
            string title;
            if (dt.Rows.Count == 0)
            {
                title = "";
            }
            else
            {
                title = dt.Rows[0]["title"].ToString();
            }
            
            return title;
        }

        public int newNewsId()
        {
            string caId = "1";
            string id;
            DataTable dt = newsmanager.SelectOneNewsByCaId(caId);
            if (dt.Rows.Count == 0)
            {
                id = "0";
            }
            else
            {
                id = dt.Rows[0]["id"].ToString();
            }
            int num = Int32.Parse(id);
            return num;
        }


        /// <summary>
        /// 绑定新闻
        /// </summary>
        private void NewList()
        {
            DataTable informAnnounce = new DataTable();
            informAnnounce = newsmanager.SelectNewNewsByCaId("8");
            inform_announce.DataSource = informAnnounce;
            inform_announce.DataBind();

            DataTable teachNews = new DataTable();
            teachNews = newsmanager.SelectNewNewsByCaId("1");
            teachnews.DataSource = teachNews;
            teachnews.DataBind();

            DataTable researchNews = new DataTable();
            researchNews = newsmanager.SelectNewNewsByCaId("2");
            researchnews.DataSource = researchNews;
            researchnews.DataBind();

            DataTable communicationNews = new DataTable();
            communicationNews = newsmanager.SelectNewNewsByCaId("3");
            communicationnews.DataSource = communicationNews;
            communicationnews.DataBind();

            DataTable organizationNews = new DataTable();
            organizationNews = newsmanager.SelectNewNewsByCaId("4");
            organizationnews.DataSource = organizationNews;
            organizationnews.DataBind();

            DataTable physicalTest = new DataTable();
            physicalTest = newsmanager.SelectNewNewsByCaId("5");
            physical_test.DataSource = physicalTest;
            physical_test.DataBind();

            DataTable testInform = new DataTable();
            testInform = newsmanager.SelectNewNewsByCaId("6");
            test_inform.DataSource = testInform;
            test_inform.DataBind();

            DataTable exerciseBook = new DataTable();
            exerciseBook = newsmanager.SelectNewNewsByCaId("7");
            exercise_book.DataSource = exerciseBook;
            exercise_book.DataBind();

            DataTable informationStation = new DataTable();
            informationStation = newsmanager.SelectOneNewsByCaId("12");
            information_station.DataSource = informationStation;
            information_station.DataBind();

            DataTable videoInformation = new DataTable();
            videoInformation = videomanager.SelectNewVideo();
            videoRepeater.DataSource = videoInformation;
            videoRepeater.DataBind();
        }


        

        protected void ibtnSearch_Click(object sender, ImageClickEventArgs e)
        {
            string key = txtSearch.Text.Trim();
            if (key == "")
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Redirect("search.aspx?key=" + Server.UrlEncode(key));
            }
        }

        public void changeTime(string createtime)
        {

        }

        protected void btnXuanfu_Click(object sender, EventArgs e)
        {

        }
    }
}