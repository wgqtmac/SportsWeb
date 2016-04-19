using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using DAL;
using Model;

namespace TheSportsWeb.login
{
    public partial class manageCommon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new CommonManager().SelectAllCommon();
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
            DataTable dt = new CommonManager().SelectAllCommon();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataTable dt = new CommonManager().SelectAllCommon();
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
            string caId = (new CommonManager().SelectById(id)).CaId;
            DataTable dt = new CategoryManager().SelectCaNameById(caId);
            string caName = dt.Rows[0]["name"].ToString();
            return caName;
        }

    }
}