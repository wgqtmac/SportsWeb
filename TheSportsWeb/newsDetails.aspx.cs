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
    public partial class newsDetails : System.Web.UI.Page
    {
        public string CaId;
        protected void Page_Load(object sender, EventArgs e)
        {
            News news = null;
            string newstypes = null;
            NewsManager newsmanager = new NewsManager();
            CategoryManager camanager = new CategoryManager();

            newstypes = Request.QueryString["newsType"];
            news = newsmanager.SelectById(newstypes);
            string b = news.Content.ToString();
            string c = news.Title.ToString();
            testId.InnerHtml = b;
            lblNews.Text = c;
            CaId = news.CaId;
            DataTable dt1 = null;
            dt1 = camanager.SelectCaNameById(CaId);
            string CaName = dt1.Rows[0]["name"].ToString();
            caName.Text = CaName;
        }
    }
}