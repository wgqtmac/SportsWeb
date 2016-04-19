using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;
using System.Data;


namespace TheSportsWeb.login
{
    public partial class alterCommon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string id = Request.QueryString["commonId"];
                Common common = new CommonManager().SelectById(id);
                txtTitle.Text = common.Title;
                fckContent.Value = common.Content;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["commonId"];
            string title = txtTitle.Text.Trim();
            string content = fckContent.Value;
            Common common = new Common();
            common.Id = id;
            common.Title = title;
            common.Content = content;
            bool b = new CommonManager().Update(common);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('顶栏内容修改成功');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('顶栏内容修改失败，请联系管理员！');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }
        }
    }
}