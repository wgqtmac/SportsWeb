<%@ Page Title="" Language="C#" MasterPageFile="~/common1.Master" AutoEventWireup="true" CodeBehind="CourseTable.aspx.cs" Inherits="TheSportsWeb.CourseTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CaName" runat="server">
课程表
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CaContent" runat="server">
 <asp:Repeater runat="server" ID="coursTable">
        <ItemTemplate>
            <%--<li>>><a href="venue.aspx?venueType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb">
                <%# DataBinder.Eval(Container.DataItem, "title")%></a></li>--%>
                <li>>><a href="inweb1.aspx?commonType=<%# DataBinder.Eval(Container.DataItem, "id")%>" target="inweb"><%# DataBinder.Eval(Container.DataItem, "title")%></a></li>
        </ItemTemplate>
        
    </asp:Repeater>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CaHeadName" runat="server">
体育教学
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="CaHead" runat="server">
课程表
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="content" runat="server">
<iframe id="inweb" width="100%" scrolling="auto" height="600" frameborder="0" src="inweb.aspx?commonType=1031" name="inweb"></iframe>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

</asp:Content>
