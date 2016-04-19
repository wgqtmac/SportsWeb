using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.IO;


namespace TheSportsWeb
{
    public partial class Login_addTeacher : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Image1.AlternateText = "图片尚未上传";
                lblNote.Visible = false;               
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.TeaName = txtName.Text.Trim();
            teacher.Party = txtParty.Text.Trim();
            teacher.Title = txtTitle.Text.Trim();
            teacher.Post = txtPost.Text.Trim();
            teacher.PicPath = ImageUrl;
            teacher.Content = fckContent.Value;
            bool a = new TeacherManager().Insert(teacher);
            if (a)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('教师信息添加成功');</script>");
                txtName.Text = "";
                txtParty.Text = "";
                txtPost.Text = "";
                txtTitle.Text = "";
                ImageUrl = "";
                fckContent.Value = "";
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
                    this.imgUpLoad.SaveAs(Server.MapPath("teaImgs/" + fileName));
                    ImageUrl = "teaImgs/" + fileName; // 呵呵路径就是这个了;
                    lblNote.Text = "头像上传成功";
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
    }
}