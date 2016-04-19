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
    public partial class venueDetails : System.Web.UI.Page
    {
        private static string venuetypes;
        protected void Page_Load(object sender, EventArgs e)
        {
            venuetypes = Request.QueryString["venueType"];
            if (!Page.IsPostBack)
            {
                //fenye(1); //绑定文章
                //int a = pds.PageCount;
                //for (int i = 1; i < a + 1; i++)
                //{
                //    DDLnews.Items.Add(new ListItem(i.ToString()));
                //}
                DataTable dt = new VenueManager().SelectAllPicByVenueId(venuetypes);
                repInfos.DataSource = dt;
                repInfos.DataBind();
            }
        }

        //private void fenye(int i)
        //{
        //    DataTable dt = new VenueManager().SelectAllPicByVenueId(venuetypes);
        //    pds.AllowPaging = true;
        //    pds.PageSize = 10;
        //    pds.CurrentPageIndex = i - 1;
        //    pds.DataSource = dt.DefaultView;
        //    repInfos.DataSource = pds;
        //    repInfos.DataBind();
        //}

        //protected void previousBtn_Click(object sender, EventArgs e)
        //{

        //}

        //protected void goBtn_Click(object sender, EventArgs e)
        //{

        //}

        //protected void nextBtn_Click(object sender, EventArgs e)
        //{

        //}
    }
}