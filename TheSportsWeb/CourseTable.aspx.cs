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
    public partial class CourseTable : System.Web.UI.Page
    {
        CommonManager commonmanager = new CommonManager();
        commonSonManager commonSonManager = new commonSonManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable course_table = new DataTable();
            course_table = commonSonManager.SelectCommonSonBySonId("1031");
            coursTable.DataSource = course_table;
            coursTable.DataBind();
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