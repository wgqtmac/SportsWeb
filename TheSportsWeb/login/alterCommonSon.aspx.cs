using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;


namespace TheSportsWeb.login
{
    public partial class alterCommonSon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string id = Request.QueryString["commonSonId"];
                CommonSon commonSon = new commonSonManager().SelectCommonSonById(id);
                txtTitle.Text = commonSon.Title;
                fckContent.Value = commonSon.Content;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["commonSonId"];
            string title = txtTitle.Text.Trim();
            string content = fckContent.Value;
            //Common common = new Common();
            CommonSon commonSon = new CommonSon();
            commonSon.Id = id;
            commonSon.Title = title;
            commonSon.Content = content;
            //bool b = new CommonManager().Update(common);
            bool b = new commonSonManager().Update(commonSon);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('二级栏目内容修改成功');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('二级栏目内容修改失败，请联系管理员！');</script>");
                txtTitle.Text = "";
                fckContent.Value = "";
            }
        }
    }
}