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
    public partial class partyUnion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Common common = new Common();
            CommonManager commonmanager = new CommonManager();
            common = commonmanager.SelectById("1");
            string c = common.Content.ToString();      //得到党组织的内容
            testId.InnerHtml = c;
        }
    }
}