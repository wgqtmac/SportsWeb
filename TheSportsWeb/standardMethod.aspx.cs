using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;

namespace TheSportsWeb
{
    public partial class standardMethod : System.Web.UI.Page
    {
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonSonManager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = commonSonManager.SelectCommonSonBySonId("1017");
            standard_method.DataSource = dt;
            standard_method.DataBind();
        }
    }
}