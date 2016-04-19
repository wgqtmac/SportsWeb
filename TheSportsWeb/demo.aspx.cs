using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheSportsWeb
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "/ckfinder/";  //设置CKFinder的基路径  
            fileBrowser.SetupCKEditor(ck1);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}