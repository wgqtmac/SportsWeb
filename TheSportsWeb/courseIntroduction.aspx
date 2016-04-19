<%@ Page Title="" Language="C#" MasterPageFile="~/common1.Master" AutoEventWireup="true" CodeBehind="courseIntroduction.aspx.cs" Inherits="TheSportsWeb.courseIntroduction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
    课程介绍
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaContent" runat="server">
    <%--<li><a href="iframe-img.html" target="inweb">>> 篮球选项课</a></li>
    <li><a href="" target="inweb">>> 排球选项课</a></li>
    <li><a href="" target="inweb">>> 足球选项课</a></li>
    <li><a href="xueshu.html" target="inweb">>> 健美操选项课</a></li>
    <li><a href="iframe-new.html" target="inweb">>> 健身健美选项课</a></li>
    <li><a href="" target="inweb">>> 街舞选项课</a></li>
    <li><a href="" target="inweb">>> 乒乓球选项课</a></li>
    <li><a href="xueshu.html" target="inweb">>> 跆拳道选项课</a></li>
    <li><a href="xueshu.html" target="inweb">>> 太极拳选项课</a></li>
    <li><a href="iframe-new.html" target="inweb">>> 散打选项课</a></li>
    <li><a href="" target="inweb">>> 艺术体操选项课</a></li>
    <li><a href="" target="inweb">>> 体育舞蹈选项课</a></li>
    <li><a href="xueshu.html" target="inweb">>> 保健康复选项课</a></li>--%>
    <asp:Repeater runat="server" ID="course_introduction">
        <ItemTemplate>
            <li>>><a href="inweb1.aspx?commonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb"><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CaHeadName" runat="server">
    体育教学
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="CaHead" runat="server">
    课程介绍
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="content" runat="server">
    <iframe id="inweb" width="100%" scrolling="auto" height="500" frameborder="0" src="inweb.aspx?commonType=1023" name="inweb"></iframe>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
