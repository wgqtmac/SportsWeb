using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Model;

namespace TheSportsWeb
{
    public partial class venue : System.Web.UI.Page
    {
        private static string venuetypes;

        protected void Page_Load(object sender, EventArgs e)
        {
            VenueManager vmanager = new VenueManager();
            commonSonManager csmanager = new commonSonManager();
            venuetypes = Request.QueryString["venueType"];
            DataTable dt = null;
            dt = vmanager.SelectNewOnePic(venuetypes);
            venues.DataSource = dt;
            venues.DataBind();
            CommonSon commonson = csmanager.SelectCommonSonById(venuetypes);
            lblTitle.Text = commonson.Title;
        }

        public string GetVenueType()
        {
            return venuetypes;
        }
    }
}