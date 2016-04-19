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
    public partial class teacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TeacherManager teamanager=new TeacherManager();
            string teachertypes=null;
            teachertypes = Request.QueryString["teacherType"];
            //News news = null;
            //string newstypes = null;
            //NewsManager newsmanager = new NewsManager();
            //CategoryManager camanager = new CategoryManager();
            //newstypes = Request.QueryString["newsType"];
            //news = newsmanager.SelectById(newstypes);
            //string b = news.Content.ToString();
            //string c = news.Title.ToString();
            //testId.InnerHtml = b;
            //lblNews.Text = c;
            //CaId = news.CaId;
            //DataTable dt1 = null;
            //dt1 = camanager.SelectCaNameById(CaId);
            //string CaName = dt1.Rows[0]["name"].ToString();
            //caName.Text = CaName;
            DataTable dt = new DataTable();
            dt = teamanager.SelectTeacherById(teachertypes);
            teacherInfos.DataSource = dt;
            teacherInfos.DataBind();
        }
    }
}