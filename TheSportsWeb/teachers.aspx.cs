using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace TheSportsWeb
{
    public partial class teachers : System.Web.UI.Page
    {
        string teacherTypes = null;
        TeacherManager teamanager = new TeacherManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            teacherTypes = Request.QueryString["teacherType"];
            DataTable dt = null;
            dt = teamanager.SelectAllTeacher();
            teacherList.DataSource = dt;
            teacherList.DataBind();
        }
    }
}