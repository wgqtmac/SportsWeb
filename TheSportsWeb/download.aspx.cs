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
    public partial class content : System.Web.UI.Page
    {
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonsonmanager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = commonsonmanager.SelectCommonSonBySonId("1025");
            download.DataSource = dt;
            download.DataBind();
        }
    }
}