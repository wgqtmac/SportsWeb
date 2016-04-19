using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace TheSportsWeb
{
    public partial class videoDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Video video = null;
            string videotypes = null;
            VideoManager videomanager = new VideoManager();
            videotypes = Request.QueryString["videoType"];
            video = videomanager.SelectVideoById(videotypes);
            string b = video.VTitle.ToString();
            string c = video.VPath.ToString();
            testId.InnerHtml = c;
            lblTitle.Text = b;
        }
    }
}