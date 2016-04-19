using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.admin
{
    public partial class left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void beijinUserLink_Click(object sender, EventArgs e)
        {
            try
            {
                HttpCookie NBIdCookie = new HttpCookie("NBId", "1");
                Response.Cookies.Add(NBIdCookie);
                Response.Write("<script>window.open('adminaddlist.aspx','main')</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void baodinUserLink_Click(object sender, EventArgs e)
        {
            try
            {
                HttpCookie NBIdCookie = new HttpCookie("NBId", "2");
                Response.Cookies.Add(NBIdCookie);
                Response.Write("<script>window.open('adminaddlist.aspx','main')</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void newsListLink(string caName, string nbId)
        {
            try
            {
                HttpCookie caNameCookie = new HttpCookie("CaName", caName);
                HttpCookie NBIdCookie = new HttpCookie("NBId", nbId);
                Response.Cookies.Add(caNameCookie);
                Response.Cookies.Add(NBIdCookie);

                Response.Write("<script>window.open('newsaddlist.aspx','main')</script>");
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void workStatusLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("工作动态", "3");
        }

        protected void beijinLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("通知公告", "1");
        }

        protected void baodinLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("通知公告", "2");
        }

        protected void xibuInfoLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("系部简介", "3");
        }

        protected void xibuLeaderLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("系部领导", "3");
        }

        protected void academicBooksLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("学术专著", "3");
        }

        protected void academicPapers_Click(object sender, EventArgs e)
        {
            newsListLink("学术论文", "3");
        }

        protected void scientificProjectLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("科研项目", "3");
        }

        protected void aonorRewards_Click(object sender, EventArgs e)
        {
            newsListLink("荣誉奖励", "3");
        }

        protected void benkeEduLinkBtn_Click(object sender, EventArgs e)
        {

        }

        protected void yjsEduLinkBtn_Click(object sender, EventArgs e)
        {

        }

        protected void jybFileLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("教育部文件", "3");
        }

        protected void jytFileLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("省教育厅文件", "3");
        }

        protected void xdwFileLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("校党委文件", "3");
        }

        protected void departFileLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("部门文件", "3");
        }

        protected void lenderAgencyLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("领导机构", "3");
        }

        protected void manageAgencyLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("管理机构", "3");
        }

        protected void educAgencyLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("教学机构", "3");
        }

        protected void academicAgencyLinkBtn_Click(object sender, EventArgs e)
        {
            newsListLink("学术机构", "3");
        }

        protected void teaIndLink_Click(object sender, EventArgs e)
        {

        }

        protected void orgLink_Click(object sender, EventArgs e)
        {

        }

        protected void teachers_Click(object sender, EventArgs e)
        {

        }

        protected void venueLink_Click(object sender, EventArgs e)
        {

        }

        protected void teachingIndLink_Click(object sender, EventArgs e)
        {

        }

        protected void regLink_Click(object sender, EventArgs e)
        {

        }

        protected void couIndLink_Click(object sender, EventArgs e)
        {

        }

        protected void gameLink_Click(object sender, EventArgs e)
        {

        }

        protected void sportsTeamLink_Click(object sender, EventArgs e)
        {

        }

        protected void activityLink_Click(object sender, EventArgs e)
        {

        }

        protected void reportLink_Click(object sender, EventArgs e)
        {

        }

        protected void policyLink_Click(object sender, EventArgs e)
        {

        }

        protected void standardLink_Click(object sender, EventArgs e)
        {

        }

        protected void partyLink_Click(object sender, EventArgs e)
        {

        }

        protected void unionLink_Click(object sender, EventArgs e)
        {

        }

        protected void downloaLink_Click(object sender, EventArgs e)
        {

        }
    }
}