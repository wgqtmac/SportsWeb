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
    public partial class LoginCommonSonAlter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string commonSonId = Request.QueryString["commonSonId"];
                CommonSon commonSon = new commonSonManager().SelectCommonSonById(commonSonId);
                txtCommon.Text = suoshufenlei(commonSonId);
                txtTitle.Text = commonSon.Title;
                fckContent.Value = commonSon.Content;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            CommonSon commonSon = new CommonSon();
            commonSon.Id = Request.QueryString["commonSonId"];
            commonSon.SonId = (new commonSonManager().SelectCommonSonById(Request.QueryString["commonSonId"])).SonId;
            commonSon.Title = txtTitle.Text;
            commonSon.Content = fckContent.Value;
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

        public static string suoshufenlei(string id)
        {
            string sonId = (new commonSonManager().SelectCommonSonById(id)).SonId;
            DataTable dt = new CommonManager().SelectCommonNameById(sonId);
            string commonName = dt.Rows[0]["title"].ToString();
            return commonName;
        }
    }
}