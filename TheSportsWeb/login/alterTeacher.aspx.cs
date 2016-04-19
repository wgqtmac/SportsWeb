using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;



namespace TheSportsWeb.login
{
    public partial class alterTeacher : System.Web.UI.Page
    {

        private static string teacherid;

        private static string ImageUrl;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                teacherid = Request.QueryString["teacherId"];
                DataTable dt = new TeacherManager().SelectTeacherById(teacherid);
                txtName.Text = dt.Rows[0]["teaName"].ToString();
                txtParty.Text = dt.Rows[0]["party"].ToString();
                txtTitle.Text = dt.Rows[0]["title"].ToString();
                txtPost.Text = dt.Rows[0]["post"].ToString();
                fckContent.Value = dt.Rows[0]["content"].ToString();
                Image1.ImageUrl = dt.Rows[0]["pic_path"].ToString();
                ImageUrl = dt.Rows[0]["pic_path"].ToString();
            }
        }

       

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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.TeaId = teacherid;
            teacher.TeaName = txtName.Text.Trim();
            teacher.Party = txtParty.Text.Trim();
            teacher.Title = txtTitle.Text.Trim();
            teacher.Post = txtPost.Text.Trim();
            teacher.PicPath = ImageUrl;
            teacher.Content = fckContent.Value;
            bool a = new TeacherManager().Update(teacher);
            if (a)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('教师信息修改成功');</script>");
                txtName.Text = "";
                txtParty.Text = "";
                txtPost.Text = "";
                txtTitle.Text = "";
                ImageUrl = "";
                fckContent.Value = "";
            }
        }
    }
}