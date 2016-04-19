using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace TheSportsWeb
{
    public partial class organization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Common common = new Common();
            CommonManager commonmanager = new CommonManager();
            common = commonmanager.SelectById("4");
            string c = common.Content.ToString();      //得到组织机构的内容
            testId.InnerHtml = c;
        }
    }
}