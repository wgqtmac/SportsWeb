using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace TheSportsWeb
{
    public partial class science : System.Web.UI.Page
    {
        NewsManager newsmanager = new NewsManager();
        SQLHelper sqlhelper = new SQLHelper();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string cmdText = "select *from news where caId=9";
            dt = sqlhelper.ExecuteQuery(cmdText, CommandType.Text);
            string text = dt.Rows[1]["content"].ToString();
            content.DataSource = dt;
            content.DataBind();
        }
    }
}