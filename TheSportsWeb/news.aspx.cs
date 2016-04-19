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
    public partial class news : System.Web.UI.Page
    {
        NewsManager newsmanager = new NewsManager();
        public static string newsTypes;
        public PagedDataSource pds = new PagedDataSource();
        protected void Page_Load(object sender, EventArgs e)
        {
            newsTypes = Request.QueryString["newsType"];
            //DataTable dt = null;
            //dt = newsmanager.SelectByCaId(newsTypes);
            //string CaName = dt.Rows[0]["name"].ToString();
            //lblCaName.Text = CaName;
            //newsList.DataSource = dt;
            //newsList.DataBind();
                if (!Page.IsPostBack)
                {
                    fenye(1); //绑定文章
                    if (pds != null)
                    {
                        int a = pds.PageCount;
                        for (int i = 1; i < a + 1; i++)
                        {
                            DDLnews.Items.Add(new ListItem(i.ToString()));
                        }
                    }
                    
                }
        }

        private void fenye(int i)
        {
            DataTable dt = newsmanager.SelectByCaId(newsTypes);
            if (dt.Rows.Count != 0)
            {
                string CaName = dt.Rows[0]["name"].ToString();
                lblCaName.Text = CaName;
                pds.AllowPaging = true;
                pds.PageSize = 10;
                pds.CurrentPageIndex = i - 1;
                pds.DataSource = dt.DefaultView;
            }
            else pds = null;
            newsList.DataSource = pds;
            newsList.DataBind();
            //repInfos.DataSource = pds;
            //repInfos.DataBind();
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

        protected void goBtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            fenye(a);
        }

        protected void nextBtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(DDLnews.SelectedValue);
            a += 1;
            DataTable dt = newsmanager.SelectByCaId(newsTypes);
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

        public string datachange(object obj)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Parse(obj.ToString());
            return dt.ToString("yyyy-MM-dd");
        }
    }
}