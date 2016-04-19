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
    public partial class Login_alterCommonSon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string id = Request.QueryString["commonSonId"];
                CommonSon commonson = new commonSonManager().SelectCommonSonById(id);
                txtTitle.Text = commonson.Title;
                fckContent.Value = commonson.Content;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}