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
    public partial class Login_newsManager : System.Web.UI.Page
    {
        public string caName = null;
        protected PagedDataSource pds = new PagedDataSource();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["username"].ToString() == "admin" && Session["userpwd"].ToString() == "nceputyjxb2014")
                {
                    if (!Page.IsPostBack)
                    {
                        fenye(1);//绑定文章

                        int a = pds.PageCount;
                        for (int i = 1; i < a + 1; i++)
                        {
                            DDLnews.Items.Add(new ListItem(i.ToString()));
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Login.aspx");
            }
            
        }

        protected void lbtnDel_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            string id = ((LinkButton)sender).CommandArgument.ToString();
            bool b = new NewsManager().Delete(id);
            if (b)
            {
                //重新绑定文章
                fenye(1);
                DDLnews.Text = "1";
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文章删除成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('未知原因导致文章删除失败！');</script>");
            }
        }

        private void fenye(int i)
        {
            DataTable dt = new NewsManager().SelectAllNews();
            pds.AllowPaging = true;
            pds.PageSize = 20;
            pds.CurrentPageIndex = i - 1;
            pds.DataSource = dt.DefaultView;
            repInfos.DataSource = pds;
            repInfos.DataBind();
        }

        public static string suoshufenlei(string id)
        {
            //int id = Convert.ToInt32(InfosId);
            //int ICaId = (new InfosDAO().SelectDetailInfosById(id)).ICaId;
            //DataTable dt = null;
            //dt = new InfoCategoryDAO().SelectInfoCaById(ICaId);
            //string ICaName1 = dt.Rows[0]["ICaName"].ToString();
            //return ICaName1;
            string caId = (new NewsManager().SelectById(id)).CaId;
            DataTable dt = new CategoryManager().SelectCaNameById(caId);
            string caName = dt.Rows[0]["name"].ToString();
            return caName;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            fenye(a);
        }

        protected void Butafter_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            a = a + 1;
            DataTable dt = new NewsManager().SelectAllNews();
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

        protected void Butbefore_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            a = a - 1;
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
    }
}