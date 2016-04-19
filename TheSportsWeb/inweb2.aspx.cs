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
    public partial class inweb3 : System.Web.UI.Page
    {
        DownloadManager downmanager = new DownloadManager();
        protected PagedDataSource pds = new PagedDataSource();
        protected static string commonSonTypes;
        protected void Page_Load(object sender, EventArgs e)
        {
            //commonSonTypes=Request.QueryString["commonSonType"];
            //DataTable dt = null;
            //dt = downmanager.SelectAllFileBySonId(commonSonTypes);
            //downList.DataSource = dt;
            //downList.DataBind();
            commonSonTypes = Request.QueryString["commonSonType"];
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


        protected void nextBtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            a += 1;
            DataTable dt = downmanager.SelectAllFileBySonId(commonSonTypes);
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


        protected void previousBtn_Click(object sender, EventArgs e)
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

        private void fenye(int i)
        {
            DataTable dt = downmanager.SelectAllFileBySonId(commonSonTypes);
            pds.AllowPaging = true;
            pds.PageSize = 10;
            pds.CurrentPageIndex = i - 1;
            pds.DataSource = dt.DefaultView;
            downList.DataSource = pds;
            downList.DataBind();
            //repInfos.DataSource = pds;
            //repInfos.DataBind();
        }

        protected void goBtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            fenye(a);
        }
    }
}