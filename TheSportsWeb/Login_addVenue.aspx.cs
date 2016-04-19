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
    public partial class Login_addVenue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new commonSonManager().SelectCommonSonBySonId("1020");
                ddlVenue.DataSource = dt;
                ddlVenue.DataTextField = "title";
                ddlVenue.DataValueField = "id";
                ddlVenue.DataBind();
                Image1.AlternateText = "图片尚未上传";
                lblNote.Visible = false;
            }
        }

        private static string ImageUrl;

        protected void btnUpLoad_Click(object sender, EventArgs e)
        {
            if (this.imgUpLoad.PostedFile.ContentLength < 1000000)//100000为100K
            {

                string fileFullname = this.imgUpLoad.FileName;
                string fileName = fileFullname.Substring(fileFullname.LastIndexOf("\\") + 1);
                string type = fileFullname.Substring(fileFullname.LastIndexOf(".") + 1);
                if (type == "bmp" || type == "jpg" || type == "gif" || type == "JPG" || type == "BMP" || type == "GIF")
                {
                    this.imgUpLoad.SaveAs(Server.MapPath("imgs/" + fileName));
                    ImageUrl = "imgs/" + fileName; // 呵呵路径就是这个了;
                    lblNote.Text = "图片上传成功";
                    lblNote.Visible = true;
                    Image1.ImageUrl = ImageUrl;
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('支持格式：|jpg|gif|bmp|');</script>");
                }
            }
            else
            {
                Response.Write("<script language='javascript'>alert('你的图片已经超过1M的大小！');</script>");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Venue venue = new Venue();
            venue.VName = txtName.Text.Trim();
            venue.VContent = fckContent.Value;
            venue.VPath = ImageUrl;
            venue.VenueId = ddlVenue.SelectedValue;
            bool a = new VenueManager().Insert(venue);
            if (a)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('场地信息添加成功');</script>");
                txtName.Text = "";
                ImageUrl = "";
                fckContent.Value = "";
            }
        }
    }
}