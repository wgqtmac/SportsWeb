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
    public partial class LoginVenueManage : System.Web.UI.Page
    {
        public string caName = null;
        protected PagedDataSource pds = new PagedDataSource();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                fenye(1); //绑定文章
                int a = pds.PageCount;
                for (int i = 1; i < a + 1; i++)
                {
                    DDLnews.Items.Add(new ListItem(i.ToString()));
                }
            }
        }

        private void fenye(int i)
        {
            DataTable dt = new commonSonManager().SelectAllCommonSon();
            pds.AllowPaging = true;
            pds.PageSize = 15;
            pds.CurrentPageIndex = i - 1;
            pds.DataSource = dt.DefaultView;
            repInfos.DataSource = pds;
            repInfos.DataBind();
        }

        public static string suoshufenlei(string id)
        {
            string sonId = (new commonSonManager().SelectCommonSonById(id)).SonId;
            DataTable dt = new CommonManager().SelectCommonNameById(sonId);
            string commonName = dt.Rows[0]["title"].ToString();
            return commonName;
        }

        protected void lbtnDel_Click(object sender, EventArgs e)
        {
            string id = ((LinkButton)sender).CommandArgument.ToString();
            bool b = new commonSonManager().Delete(id);
            if (b)
            {
                fenye(1);
                DDLnews.Text = "1";
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文章删除成功');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('未知原因导致文章删除失败！');</script>");
            }
        }

        protected void Butbefore_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            a -= 1;
            if (a < 1)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('已经到第一页');</script>");
            }
            else
            {
                DDLnews.Text = a.ToString();
                fenye(a);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            fenye(a);
        }

        protected void Butafter_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            a =a+1;
            DataTable dt = new commonSonManager().SelectAllCommonSon();
            pds.AllowPaging = true;
            pds.PageSize = 10;

            pds.DataSource = dt.DefaultView;
            if (a > pds.PageCount)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('已经到最后一页');</script>");
            }
            else
            {
                DDLnews.Text = a.ToString();
                fenye(a);
            }
        }

        protected void lbtnDel_Click1(object sender, EventArgs e)
        {

        }
    }
}