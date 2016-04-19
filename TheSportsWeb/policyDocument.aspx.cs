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
    public partial class policyDocument : System.Web.UI.Page
    {
        //NewsManager newsmanager = new NewsManager();
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonSonManager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = newsmanager.SelectByCaId("1021");
            //policy_document.DataSource = dt;
            //policy_document.DataBind();
            DataTable dt = new DataTable();
            dt = commonSonManager.SelectCommonSonBySonId("1016");
            policy_document.DataSource = dt;
            policy_document.DataBind();
        }
    }
}