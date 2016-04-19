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
    public partial class manageNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DataTable dt = new NewsManager().SelectAllNews();
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            bool b = new NewsManager().Delete(id);
            if (b)
            {                
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文章删除成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('未知原因导致文章删除失败！');</script>");
            }
            Response.Redirect("manageNews.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            DataTable dt = new NewsManager().SelectAllNews();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        public static string suoshufenlei(string id)
        {
            //int id = Convert.ToInt32(InfosId);
            //int ICaId = (new InfosDAO().SelectDetailInfosById(id)).ICaId;
            //DataTable dt = null;
            //dt = new InfoCategoryDAO().SelectInfoCaById(ICaId);
            //string ICaName1 = dt.Rows[0]["ICaName"].ToString();
            //return ICaName1;
            string caId = (new NewsManager().SelectById(id)).CaId;
            DataTable dt = new CategoryManager().SelectCaNameById(caId);
            string caName = dt.Rows[0]["name"].ToString();
            return caName;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataTable dt = new NewsManager().SelectAllNews();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            
        }


       
    }
}