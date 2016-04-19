using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Model;

namespace TheSportsWeb.login
{
    public partial class manageCommonSon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new commonSonManager().SelectAllCommonSon();
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
            DataTable dt = new commonSonManager().SelectAllCommonSon();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            bool b = new commonSonManager().Delete(id);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('二级栏目删除成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('未知原因导致删除失败！');</script>");
            }
            Response.Redirect("manageCommonSon.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataTable dt = new commonSonManager().SelectAllCommonSon();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        public static string suoshufenlei(string id)
        {
            string sonId = (new commonSonManager().SelectCommonSonById(id)).SonId;
            DataTable dt = new CommonManager().SelectCommonNameById(sonId);
            string commonName = dt.Rows[0]["title"].ToString();
            return commonName;
        }
    }
}