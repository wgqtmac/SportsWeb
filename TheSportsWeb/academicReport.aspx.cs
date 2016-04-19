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
    public partial class academicReport : System.Web.UI.Page
    {
        //CommonManager commonmanager = new CommonManager();
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonSonManager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = commonmanager.SelectNewNewsByCaId("1015");
            //science_report.DataSource = dt;
            //science_report.DataBind();
            DataTable dt = new DataTable();
            //finess_facilities = commonmanager.SelectNewNewsByCaId("17");
            dt = commonSonManager.SelectCommonSonBySonId("1019");
            science_report.DataSource = dt;
            science_report.DataBind();
        }
    }
}