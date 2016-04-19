using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheSportsWeb.login
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                if (Session["username"].ToString() == "admin" && Session["userpwd"].ToString() == "nceputyjxb2014")
                {
                    Label3.Text = "admin";
                }
            }
            catch (Exception)
            {
                Response.Redirect("../Login.aspx");
            }
            
        }
    }
}