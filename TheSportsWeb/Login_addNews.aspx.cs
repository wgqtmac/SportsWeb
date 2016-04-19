using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace TheSportsWeb
{
    public partial class addNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new CategoryManager().SelectAll();
                ddlCategory.DataSource = dt;
                ddlCategory.DataTextField = "name";
                ddlCategory.DataValueField = "id";
                ddlCategory.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = fckContent.Value;
            string caId = ddlCategory.SelectedValue;
            News news=new News();
            news.CaId=caId;
            news.Title = title;
            news.Content=content;
            Picture pic = new Picture();
            pic.Title = title;
            pic.Content = title;
            pic.Paths = Select_Path(fckContent.Value);
            pic.CaId = caId;

            if (pic.Paths.Trim() != "")
            {
                bool a = new PictureManager().Insert(pic);
            }          
            //bool a = new PictureManager().Insert(pic);
            bool b = new NewsManager().Insert(news);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻添加成功');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻添加失败，请联系管理员！');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }

        }

        //提取FCK中的图片路径
        protected string Select_Path(string value)
        {
            string newStr = fckContent.Value;
            int imgf = newStr.IndexOf("UploadFiles");
            int img1 = newStr.IndexOf("jpg");
            string path = "";
            if (imgf != -1 && img1 != -1)
            {
                path = newStr.Substring(imgf, img1 - imgf + 3);
            }
            return path;
        }
    }
}