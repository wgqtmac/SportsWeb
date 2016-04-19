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
    public partial class sportsTeam : System.Web.UI.Page
    {
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonSonManager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //finess_facilities = commonmanager.SelectNewNewsByCaId("17");
            dt = commonSonManager.SelectCommonSonBySonId("1021");
            sports_team.DataSource = dt;
            sports_team.DataBind();
        }
    }
}