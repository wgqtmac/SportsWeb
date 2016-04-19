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
    public partial class inweb : System.Web.UI.Page
    {
        public string CaId;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //CommonSon commonSon = new CommonSon();
            //string commontypes = null;
            //commonSonManager commonsonmanager = new commonSonManager();
            //commontypes = Request.QueryString["commonType"];
            //commonSon = commonsonmanager.SelectCommonSonById(commontypes);
            Common common = new Common();
            string commontypes = null;
            CommonManager commonmanager = new CommonManager();
            commontypes = Request.QueryString["commonType"];
            common = commonmanager.SelectById(commontypes);
            string b = common.Content.ToString();
            string c = common.Title.ToString();
            testId.InnerHtml = b;
            lblCommon.Text = c;
        }
    }
}