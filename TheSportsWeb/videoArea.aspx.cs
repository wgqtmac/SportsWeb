using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;

namespace TheSportsWeb
{
    public partial class videoArea : System.Web.UI.Page
    {
        string videoTypes = null;
        VideoManager videoManager = new VideoManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            videoTypes = Request.QueryString["videoType"];
            DataTable dt = null;
            dt = videoManager.SelectAllVideo();
            videoList.DataSource = dt;
            videoList.DataBind();
        }
    }
}