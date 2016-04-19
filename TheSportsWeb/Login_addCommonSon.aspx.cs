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
    public partial class Login_addCommonSon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new CommonManager().SelectCommonHaveSon();
                commonDDL.DataSource = dt;
                commonDDL.DataTextField = "title";
                commonDDL.DataValueField = "id";
                commonDDL.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = fckContent.Value;
            string commonId = commonDDL.SelectedValue;
            CommonSon commonSon = new CommonSon();
            commonSon.SonId = commonId;
            commonSon.Title = title;
            commonSon.Content = content;
            bool b = new commonSonManager().Insert(commonSon);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('二级栏目添加成功');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('二级栏目添加失败，请联系管理员！');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }
        }
    }
}