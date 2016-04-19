using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace TheSportsWeb
{
    public partial class Login_video : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
            }
        }

        protected void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = fckVideo.Value;
            Video video = new Video();
            video.VTitle = title;
            video.VPath = content;
            bool a = new VideoManager().Insert(video);
            if (a)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('视频添加成功');</script>");
                txtTitle.Text = "";
                fckVideo.Value = "";
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('视频添加失败，请联系管理员！');</script>");
                txtTitle.Text = "";
                fckVideo.Value = "";
            }
        }
    }
}