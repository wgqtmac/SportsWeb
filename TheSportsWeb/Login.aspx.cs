using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheSportsWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //if ((txtName.Text.ToString() == "admin" && txtPwd.Text.ToString() == "ncepu"))
            //{
                
            //    Response.Redirect("Login_newsManager.aspx");
            //}
            Session["username"]=txtName.Text.ToString();
            Session["userpwd"] = txtPwd.Text.ToString();
            if(txtName.Text.ToString()=="admin"&&txtPwd.Text.ToString()=="nceputyjxb2014")
            {
                //Response.Redirect("Login_newsManager.aspx");
                Response.Redirect("login/Main.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('用户名或密码错误，登录失败！请您重新输入！');</script>"); 
            }
        }

       
    }
}