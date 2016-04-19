using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace TheSportsWeb
{
    public partial class inweb1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonSon commonSon = new CommonSon();
            string commontypes = null;
            commonSonManager commonsonmanager = new commonSonManager();
            commontypes = Request.QueryString["commonType"];
            commonSon = commonsonmanager.SelectCommonSonById(commontypes);
            string b = commonSon.Content.ToString();
            string c = commonSon.Title.ToString();
            testId.InnerHtml = b;
            lblCommon.Text = c;
        }
    }
}