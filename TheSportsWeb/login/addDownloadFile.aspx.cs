using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace TheSportsWeb.login
{
    public partial class addDownloadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new commonSonManager().SelectCommonSonBySonId("1025");
                comonSonDDL.DataSource = dt;
                comonSonDDL.DataTextField = "title";
                comonSonDDL.DataValueField = "id";
                comonSonDDL.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (fileDownload.HasFile)
            {
                fileDownload.SaveAs(Server.MapPath("../Download/" + fileDownload.FileName));
                File file = new File();
                file.DTitle = txtTitle.Text.Trim();
                file.Down_path = "Download/" + fileDownload.FileName;
                file.DownId = comonSonDDL.SelectedValue;
                bool b = new DownloadManager().Insert(file);
                if (b)
                {

                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('上传文件成功');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('文件上传失败');</script>");
            }
        }
    }
}