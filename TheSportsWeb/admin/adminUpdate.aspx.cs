using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace TheSportsWeb.admin
{
    public partial class adminUpdate : System.Web.UI.Page
    {
        
       
        protected void Page_Load(object sender, EventArgs e)
        { 
            CommonManager commonmanager = new CommonManager();
            Common common = null;
            string commontypes = null;
            commontypes = Request.QueryString["commonType"];
            common = commonmanager.SelectById(commontypes);
            //updateCommonCKEdit.Text = common.Content.ToString();
            updateCommonFck.Value = common.Content.ToString();
            txtCommon.Text = common.Title.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Common common = new Common();
            //common.Content = updateCommonCKEdit.Text.ToString();
            common.Content = updateCommonFck.Value.ToString();
            common.Title = txtCommon.Text.ToString();
            common.Id = Request.QueryString["commonType"];
            bool b = new CommonManager().Update(common);
            if (b)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('顶栏内容修改成功');</script>");
                updateCommonFck.Value = "";
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('顶栏内容修改失败，请联系管理员！');</script>");
                //updateCommonCKEdit.Text = common.Content.ToString();
                updateCommonFck.Value = "";
            }
        }
    }
}