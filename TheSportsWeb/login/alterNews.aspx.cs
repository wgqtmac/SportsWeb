using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;
using System.Data;

namespace TheSportsWeb.login
{
    public partial class alterNews : System.Web.UI.Page
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
                string newsId = Request.QueryString["newsId"];
                News news = new NewsManager().SelectById(newsId);
                fckContent.Value = news.Content;
                ddlCategory.SelectedValue = newsId.ToString();
                txtTitle.Text = news.Title;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["newsId"];
            string title = txtTitle.Text.Trim();
            string content = fckContent.Value;
            string caId = ddlCategory.SelectedValue;
            News news = new News();
            news.CaId = caId;
            news.Title = title;
            news.Content = content;
            news.Id = newsId;
            bool b = new NewsManager().Update(news);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻修改成功');</script>");
                string Id = Request.QueryString["newsId"];
                news = new NewsManager().SelectById(Id);
                //txtTitle.Text = "";
                //fckContent.Value = "";
                txtTitle.Text = news.Title;
                fckContent.Value = news.Content;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('新闻修改失败，请联系管理员！');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }
        }
    }
}