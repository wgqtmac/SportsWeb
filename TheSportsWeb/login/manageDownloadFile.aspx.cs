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
    public partial class manageDownloadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DownloadManager().SelectAllFile();
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            DataTable dt = new DownloadManager().SelectAllFile();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //bool b = new commonSonManager().Delete(id);
            bool b = new DownloadManager().Delete(id);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文件删除成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('未知原因导致删除失败！');</script>");
            }
            Response.Redirect("manageDownloadFile.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataTable dt = new DownloadManager().SelectAllFile();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        public static string suoshufenlei(string id)
        {
            string downId = (new DownloadManager().SelectFileById(id)).DownId;
            string commonSonName = (new commonSonManager().SelectCommonSonById(downId)).Title;
            return commonSonName;
        }
    }
}