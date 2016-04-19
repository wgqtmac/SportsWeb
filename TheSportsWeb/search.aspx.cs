using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TheSportsWeb
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string key = Server.UrlDecode(Request.QueryString["key"]);
                newsList.DataSource = new NewsManager().SelectByTitle(key);
                newsList.DataBind();
            }
        }
    }
}