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
    public partial class veneuFacilities : System.Web.UI.Page
    {
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonSonManager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable finess_facilities = new DataTable();
            finess_facilities = commonSonManager.SelectCommonSonBySonId("1020");
            finessFacilities.DataSource = finess_facilities;
            finessFacilities.DataBind();
        }

        public int GetNewsType(string name)
        {
            DataTable dt = new DataTable();
            dt = commonmanager.SelectNewNewsByCaId(name);
            string id = dt.Rows[0]["id"].ToString();
            int a = Convert.ToInt32(id);
            return a;
        }
    }
}