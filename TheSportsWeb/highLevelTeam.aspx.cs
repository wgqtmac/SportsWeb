﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace TheSportsWeb
{
    public partial class highLevelTeam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Common common = new Common();
            CommonManager commonmanager = new CommonManager();
            common = commonmanager.SelectById("1035");
            string c = common.Content.ToString();      //得到高水平代表队的内容
            testId.InnerHtml = c;
        }
    }
}