using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace TheSportsWeb
{
    public partial class commonDetails : System.Web.UI.Page
    {
        public string commonId;
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonSon commonSon = null;
            string commontypes = null;
            commonSonManager commonSonManager = new commonSonManager();
            CommonManager commonManager = new CommonManager();
            commontypes = Request.QueryString["commonType"];
            commonSon = commonSonManager.SelectCommonSonById(commontypes);
            string b = commonSon.Content.ToString();
            string c = commonSon.Title.ToString();
            testId.InnerHtml = b;
            commonName.Text = c;
            commonId = commonSon.SonId;
            DataTable dt1 = null;
            dt1 = commonManager.SelectCommonNameById(commonId);
            string comonName = dt1.Rows[0]["title"].ToString();
            caName.Text = comonName;
        }
    }
}